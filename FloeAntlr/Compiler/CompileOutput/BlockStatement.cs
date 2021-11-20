using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Compiler.CompileOutput
{
    public enum BlockCondition
    {
        EQ,
        GT,
        GTE,
        LT,
        LTE
    }
    public class BlockStatement : IStatement
    {
        public StatementType Type => StatementType.BLOCK;
        public string BlockRegister;

        public string LeftValue;
        public BlockCondition Condition;
        public string RightValue;

    }
}
