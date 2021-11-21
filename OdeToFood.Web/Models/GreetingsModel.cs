using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Web.Models
{
    public class GreetingsModel
    {
        public string Message { get; set; }
        public string Name { get; internal set; }
    }
}