using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Execution
{
    public class ExecutionState
    {
        public List<RegisterNode> Registers { get; set; }
        public List<ExecutionNode> ExecutionNodes { get; set; }
    }
}
