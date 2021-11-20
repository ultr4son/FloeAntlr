using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Compiler.CompileOutput
{
    public class NodeStatement : IStatement
    {
        private StatementType type;
        public NodeStatement(NodeType type)
        {
            this.type = (StatementType)type;
        }
        StatementType IStatement.Type => type;

        public string Name;
        public string[] Args;
        public string[] Outputs;
    }
}
