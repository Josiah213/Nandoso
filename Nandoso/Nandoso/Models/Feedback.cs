using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Nandoso.Models
{
    public class Feedback
    {
        public int ID { get; set; }
        public string CommentorName { get; set; }
        public string Comment { get; set; }
    }
}