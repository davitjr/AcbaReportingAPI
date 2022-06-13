using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.IO;

namespace AcbaReportsApi.Application.Helpers
{
    public class SystemIOHelper : ISystemIOHelper
    {
        public byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[64 * 1024];
            using MemoryStream ms = new MemoryStream();
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }
            return ms.ToArray();
            //byte[] result;
            //using (var streamReader = new MemoryStream())
            //{
            //    input.CopyTo(streamReader);
            //    result = streamReader.ToArray();
            //}
            //return result;
        }
    }
}
