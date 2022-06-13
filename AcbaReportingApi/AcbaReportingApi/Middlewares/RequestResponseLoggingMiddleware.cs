using Microsoft.Extensions.Options;
using Microsoft.IO;
using AcbaReportsApi.Application.Settings;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace AcbaReportsApi.Middlewares
{
    public class RequestResponseLoggingMiddleware
    {
        public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger, IOptions<AcbaReportsApiOptions> AcbaReportsApiOptions)
        {
            _next = next;
            _logger = logger;
            _recyclableMemoryStreamManager = new RecyclableMemoryStreamManager();
            _AcbaReportsApiApiOptions = AcbaReportsApiOptions.Value;
        }

        private readonly AcbaReportsApiOptions _AcbaReportsApiApiOptions;
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;
        private readonly RecyclableMemoryStreamManager _recyclableMemoryStreamManager;

        public async Task Invoke(HttpContext context)
        {
            await LogRequest(context);
            await LogResponse(context);
        }

        private async Task LogRequest(HttpContext context)
        {
            await LogRequest(context.Request);
            context.Request.Body.Position = 0;
        }
        private async Task LogResponse(HttpContext context)
        {
            Stream originalBodyStream = context.Response.Body;
            await using MemoryStream responseBody = _recyclableMemoryStreamManager.GetStream();
            context.Response.Body = responseBody;

            await _next(context);

            await LogResponse(context, responseBody);
            await responseBody.CopyToAsync(originalBodyStream);
        }
        private static string ReadStreamInChunks(Stream stream)
        {
            const int readChunkBufferLength = 4096;
            stream.Seek(0, SeekOrigin.Begin);
            using StringWriter textWriter = new();
            using StreamReader reader = new(stream);
            char[] readChunk = new char[readChunkBufferLength];
            int readChunkLength;
            do
            {
                readChunkLength = reader.ReadBlock(readChunk, 0, readChunkBufferLength);
                textWriter.Write(readChunk, 0, readChunkLength);
            } while (readChunkLength > 0);
            return textWriter.ToString();
        }
        private async Task LogRequest(HttpRequest request)
        {
            request.EnableBuffering();
            await using MemoryStream requestStream = _recyclableMemoryStreamManager.GetStream();
            await request.Body.CopyToAsync(requestStream);
            string text = ReadStreamInChunks(requestStream);
            _logger.LogInformation("Http Request Information: \r\n Scheme:{Scheme} " +
                "Host:{Host} Path:{Path} QueryString:{QueryString} Request Body:{Text}",
                   request.Scheme, request.Host, request.Path, request.QueryString, text);
        }
        private async Task LogResponse(HttpContext context, MemoryStream responseBody)
        {
            responseBody.Seek(0, SeekOrigin.Begin);
            string text = _AcbaReportsApiApiOptions.EnableOkResponseLogging ? await new StreamReader(responseBody).ReadToEndAsync() : string.Empty;
            responseBody.Seek(0, SeekOrigin.Begin);
            _logger.LogInformation("Http Response Information: \r\n Scheme:{Scheme} StatusCode:{StatusCode} " +
                "Host:{Host} Path:{Path} QueryString:{QueryString} Response Body:{Text}",
                context.Request.Scheme, context.Response.StatusCode, context.Request.Host,
                context.Request.Path, context.Request.QueryString, text);
        }
    }
}
