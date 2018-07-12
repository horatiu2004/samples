using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApplication.Models
{
    public enum ExportType
    {
        [Display(Name = "XML")]
        Xml,
        [Display(Name = "JSON")]
        Json
    }
    public class ExportModel
    {
        public ExportType ExportType { get; set; }
    }
}
