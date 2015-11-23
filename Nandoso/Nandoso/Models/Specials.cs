using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;


namespace Nandoso.Models
{
    public class Specials
    {
        public int ID { get; set; }
        public string SpecialName { get; set; }
        public string SpecialPrice { get; set; }
        public byte[] picture { get; set; }

    }
}