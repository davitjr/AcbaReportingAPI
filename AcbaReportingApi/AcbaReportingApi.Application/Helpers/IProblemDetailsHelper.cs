using Microsoft.AspNetCore.Mvc;

namespace AcbaReportsApi.Application.Helpers
{
    public interface IProblemDetailsHelper
    {
        ProblemDetails GetGlobalProblemDetails();
    }
}