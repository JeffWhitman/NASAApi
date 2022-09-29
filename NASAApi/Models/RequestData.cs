using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAApi.Models
{
    public  class RequestData
    {
        public string date { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public int count { get; set; }
        public bool thumbs { get; set; }
    }
}
