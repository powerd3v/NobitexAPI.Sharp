using System;
using System.Collections.Generic;
using System.Text;

namespace NobitexAPI.Sharp.Exceptions
{
    public class NobitexException
    {
        public string detail { get; set; }
    }
    public class AddOrderException
    {
        public string status { get; set; }
        public string code { get; set; }
        public string message { get; set; }
    }
}
