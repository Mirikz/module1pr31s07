using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1pr31s07
{
    public class ProgrammersChild: Programmer
    {
        public int P;
        public int qp;
        new public int Q(int P, int Q)
        {
            int qp = P * Q / count_of_programs;
            return qp;
        }
    }
}
