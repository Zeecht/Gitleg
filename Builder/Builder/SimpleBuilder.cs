using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class SimpleBuilder : IRobotBuilder
    {
        private Robot robot;

        public void BuildArms()
        {
            robot.Arms = "Simple Arms";
        }

        public void BuildBody()
        {
            robot.Body = "Simple Body";
        }

        public void BuildHead()
        {
            robot.Head = "Simple Head";
        }

        public void BuildLegs()
        {
            robot.Legs = "Simple Legs";
        }

        public Robot GetResult()
        {
            return robot;
        }
    }
}
