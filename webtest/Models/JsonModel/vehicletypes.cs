using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webtest.Models.JsonModel
{
    public class vehicletypes
    {
        public int status { get; set; }
        public VehicleMeta[] vehicletype { get; set; }
    }
    public class VehicleMeta
    {
        public int typeId { get; set; }
        public string typeName { get; set; }
    }
}