using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IRobotBuilder
    {

        Robot GetResult();

        void BuildHead();

        void BuildArms();

        void BuildBody();

        void BuildLegs();
    }
}
