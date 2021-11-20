using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Parser
{
    static class Parser
    {
        public static IParseTree GenerateParseTree(string input)
        {
            ICharStream stream = CharStreams.fromString(input);
            ITokenSource lexer = new floeLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            floeParser parser = new floeParser(tokens);
            parser.BuildParseTree = true;
            IParseTree tree = parser.program();

            return tree;
        }

        
    }
}
