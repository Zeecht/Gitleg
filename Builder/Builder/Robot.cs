using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Robot
    {
        private string head;
        private string arms;
        private string body;
        private string legs;

        public string Head { get => head; set => head = value; }
        public string Arms { get => arms; set => arms = value; }
        public string Body { get => body; set => body = value; }
        public string Legs { get => legs; set => legs = value; }
    }
}
