using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Web.Models
{
    public class BarChartCM
    {
        public BarChartCM()
        {
            labels = new List<string>();
            datasets = new List<BarChartChildCM>();
        }
        public List<string> labels { get; set; }
        public List<BarChartChildCM> datasets { get; set; }
    }
    public class BarChartChildCM
    {
        public BarChartChildCM()
        {
            data = new List<int>();
        }
        public string label { get; set; }
        


        public string backgroundColor { get; set; }
        public string borderColor { get; set; }
        public string hoverBackgroundColor { get; set; }

        public List<int> data { get; set; }
    }
}