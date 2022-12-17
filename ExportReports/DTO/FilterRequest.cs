using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExportReports.DTO
{
    public class FilterRequest
    {
        public string? Company { get; set; } = null;
        public string? ProjDept  { get; set; } = null;
        public string? ItemGroups {get;set;} = null;
        public string? ItemSubGroups {get;set;} = null;
        public string? ItemCategory  {get;set;}= null;
        public string? ItemSubCategory {get;set;} = null;
        public string? DateFrom {get;set;} = null;
        public string? DateTo {get;set;} = null;
    }
}