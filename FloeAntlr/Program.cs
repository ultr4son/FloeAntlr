using Antlr4.Runtime.Tree;
using FloeAntlr.Compiler.CompileOutput;
using System;
using System.Collections.Generic;
using System.IO;
namespace FloeAntlr
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Floe parser.");
                return;
            }

            string path = args[0];

            string contents = System.IO.File.ReadAllText(path);

            IParseTree tree = Parser.Parser.GenerateParseTree(contents);
            List<IStatement> statements = Compiler.Compiler.Compile(tree);
        }
    }
}
