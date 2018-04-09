using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BattleBuilder : IRobotBuilder
    {
        private Robot robot;

        public BattleBuilder(Robot robot)
        {
            this.robot = robot;
        }

        public void BuildArms()
        {
            //robot.Arms = Console.WriteLine("Battle Arms");
        }

        public void BuildBody()
        {
            robot.Body = "Battle Body";
        }

        public void BuildHead()
        {
            robot.Head = "Battle Head";
        }

        public void BuildLegs()
        {
            robot.Legs = "Battle Legs";
        }



        public Robot GetResult()
        {
            return robot;
        }

        
    }
}
