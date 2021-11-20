using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Execution.Builtin
{
    public class PrintNode : ExecutionNode
    {
        public override int DoComputation(int[] argv)
        {
            Console.WriteLine(argv[0]);
            return 0;
        }
    }
}
