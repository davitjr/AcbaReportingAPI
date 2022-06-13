using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AcbaReportsApi.Application.Models
{
    /// <summary>
    /// File Export Formats.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExportFormat
    {
        /// <summary>Image</summary>
        Image,
        /// <summary>PDF</summary>
        PDF,
        /// <summary>Excel</summary>
        Excel,
        /// <summary>Word</summary>
        Word
    }


}
