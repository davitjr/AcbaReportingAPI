using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace AcbaReportsApi.Application.Helpers
{
    public interface ISystemIOHelper
    {
        byte[] ReadFully(Stream input);
    }
}