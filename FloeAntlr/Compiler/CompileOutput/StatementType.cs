using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Compiler.CompileOutput
{
    public enum StatementType
    {
        NODE_BUILTIN_ADD,
        NODE_BUILTIN_SUBTRACT,
        NODE_BUILTIN_DIVIDE,
        NODE_BUILTIN_MULTIPLY,
        NODE_BUILTIN_PRINT,
        NODE,
        NODE_REGISTER,
        REGISTER_ASSIGN,
        BLOCK
    }
    public enum NodeType
    {
        NODE_BUILTIN_ADD = StatementType.NODE_BUILTIN_ADD,
        NODE_BUILTIN_SUBTRACT = StatementType.NODE_BUILTIN_SUBTRACT,
        NODE_BUILTIN_DIVIDE = StatementType.NODE_BUILTIN_DIVIDE,
        NODE_BUILTIN_MULTIPLY = StatementType.NODE_BUILTIN_MULTIPLY,
        NODE_BUILTIN_PRINT = StatementType.NODE_BUILTIN_PRINT,
        NODE = StatementType.NODE
    }
}
