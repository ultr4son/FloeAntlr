using Antlr4.Runtime.Misc;
using FloeAntlr.Compiler.CompileOutput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Compiler.Visitor
{
    public class FloeVisitor : floeBaseVisitor<List<IStatement>>
    {        
        public override List<IStatement> VisitProgram([NotNull] floeParser.ProgramContext context)
        {
            List<IStatement> statements = new List<IStatement>();
            floeParser.StatementContext[] statementContexts = context.statement();
            foreach(floeParser.StatementContext statementContext in statementContexts)
            {
                List<IStatement> statement = VisitStatement(statementContext);
                statements = statements.Concat(statement).ToList();
            }
            return statements;
        }
        public override List<IStatement> VisitAssign_statement([NotNull] floeParser.Assign_statementContext context)
        {
            AssignStatement statement = new AssignStatement();

            statement.RegisterName = context.NAME().GetText();
            statement.Value = context.INT_LITERAL().GetText();

            return new List<IStatement>() { statement };
        }

     
        public override List<IStatement> VisitBlock_statement([NotNull] floeParser.Block_statementContext context)
        {            
            floeParser.Block_conditionContext blockCondition = context.block_condition();
            BlockCondition condition = BlockStatement.TokenAsBlockCondition(blockCondition.block_compare().RuleIndex);

            return new List<IStatement>() { 
                new BlockStatement() { 
                    BlockRegister = context.NAME().GetText(), 
                    Condition = condition, 
                    LeftValue = context.block_condition().value()[0].GetText(), 
                    RightValue = context.block_condition().value()[1].GetText() 
                } 
            };
            

        }

        public override List<IStatement> VisitConnection_statement([NotNull] floeParser.Connection_statementContext context)
        {
            floeParser.SourceContext source = context.source();
            string inputName;
            string[] outputs = { context.NAME().GetText() };

            if (source.RuleIndex == floeParser.RULE_node)
            {
                floeParser.NodeContext node = source.node();
                inputName = node.node_name().GetText();
                StatementType nodeType;

                switch (inputName)
                {
                    case "add":
                        nodeType = StatementType.NODE_BUILTIN_ADD;
                        break;
                    case "subtract":
                        nodeType = StatementType.NODE_BUILTIN_SUBTRACT;
                        break;
                    case "multiply":
                        nodeType = StatementType.NODE_BUILTIN_MULTIPLY;
                        break;
                    case "divide":
                        nodeType = StatementType.NODE_BUILTIN_DIVIDE;
                        break;
                    case "print":
                        nodeType = StatementType.NODE_BUILTIN_PRINT;
                        break;
                    default:
                        nodeType = StatementType.NODE;
                        break;
                }

                string[] args = node.arg_list().GetText().Split(",");

                return new List<IStatement>() { new NodeStatement((NodeType)nodeType) { Name = inputName, Args = args, Outputs = outputs } };
            }
            if (source.RuleIndex == floeParser.NAME)
            {
                inputName = source.GetText();
                return new List<IStatement>() { new NodeRegisterStatement() { InputRegister = inputName, OutputRegisters = outputs } };
            }
            throw new Exception("Invalid rule index " + source.RuleIndex);

        }

        
    }
}
