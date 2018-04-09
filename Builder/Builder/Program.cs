using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot rob = new Robot();
            BattleBuilder battle = new BattleBuilder(rob);
            RobotDirector robot = new RobotDirector(battle);
            robot.Construct();
            
            Console.WriteLine(rob.Head.ToString());
            Console.ReadKey();
        }
    }
}
