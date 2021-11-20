using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Compiler.CompileOutput
{
    public class NodeInfo
    {
        public string Name;
        public List<string> Outputs;
        public List<string> Inputs;
        public NodeType Type;
    }
}
