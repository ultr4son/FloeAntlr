using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Execution.Builtin
{
    public class ArithmeticNode : ExecutionNode
    {
        public delegate int BinaryOp(int a, int b);
        public BinaryOp op;

        public override int DoComputation(int[] argv)
        {
            return op(argv[0], argv[1]);
        }
    }
}
