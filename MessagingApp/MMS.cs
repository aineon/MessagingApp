using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp
{
    // Declares additional properties belonging to MMS 
    class MMS : Message
    {
        public bool Picture { get; set; }
        public bool Video { get; set; }
        public bool Audio { get; set; }
        public string FileName { get; set; }

        public MMS()
        {

        }
    }
}
