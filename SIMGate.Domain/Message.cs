using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMGate.Domain
{
    public class Message
    {
        public bool Incoming { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
