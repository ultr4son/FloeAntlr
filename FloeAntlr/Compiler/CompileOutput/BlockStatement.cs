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
        public static BlockCondition TokenAsBlockCondition(int token)
        {
            switch (token)
            {
                case floeParser.EQ:
                    return BlockCondition.EQ;
                case floeParser.GT:
                    return BlockCondition.GT;
                case floeParser.GTE:
                    return BlockCondition.GTE;
                case floeParser.LT:
                    return BlockCondition.LT;
                case floeParser.LTE:
                    return BlockCondition.LTE;
                default:
                    throw new ArgumentException("Invalid token value.");
            }
        }

    }
}
