using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Compiler.CompileOutput
{
    public class NodeRegisterStatement : IStatement
    {
        StatementType IStatement.Type => StatementType.REGISTER_ASSIGN;
        public string InputRegister;
        public string[] OutputRegisters;
    }
}
