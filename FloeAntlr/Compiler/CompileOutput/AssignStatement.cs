using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Compiler.CompileOutput
{
    public class AssignStatement : IStatement
    {
        public StatementType Type => StatementType.REGISTER_ASSIGN;

        public string RegisterName;
        public string Value;
    }
}
