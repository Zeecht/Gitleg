using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class RobotDirector
    {
        private IRobotBuilder builder;

        public RobotDirector(IRobotBuilder builder)
        {
            this.builder = builder;
        }

        public Robot Construct()
        {
            builder.BuildHead();
            builder.BuildArms();
            builder.BuildBody();
            builder.BuildLegs();

            return builder.GetResult();
        }
    }
}
