using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace AcbaReportsApi.Application.Helpers
{
    public class ProblemDetailsHelper : IProblemDetailsHelper
    {
        private IStringLocalizer<SharedResource> localizer;
        public ProblemDetailsHelper(IStringLocalizer<SharedResource> localizer)
        {
            localizer = localizer;
        }
        public ProblemDetails GetGlobalProblemDetails()
        {
            return new ProblemDetails { Type = localizer["SomethingWentWrongType"], Title = localizer["SomethingWentWrongTitle"], Detail = localizer["SomethingWentWrongMessage"], Status = StatusCodes.Status500InternalServerError };
        }
    }
}
