using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp
{
    // Declares properties common to SMS & MMS messages
    abstract class Message
    {
        public int ID { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
        public bool IsGroupMessage { get; set; }
        public bool MMS { get; set; }
    }
}
