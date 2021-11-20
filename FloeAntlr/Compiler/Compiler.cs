using Antlr4.Runtime.Tree;
using FloeAntlr.Compiler.CompileOutput;
using FloeAntlr.Compiler.Visitor;
using FloeAntlr.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Compiler
{
    public static class Compiler
    {
        //public static ExecutionState AsExecutionState(List<IStatement> parseTree)
        //{
            

        //}

        public static List<IStatement> Compile(IParseTree parseTree)
        {
            FloeVisitor visitor = new FloeVisitor();

            return visitor.Visit(parseTree);
        }
    }
}
