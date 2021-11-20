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


        public override List<IStatement> VisitStatement([NotNull] floeParser.StatementContext context)
        {
            return base.VisitStatement(context);
        }

        public override List<IStatement> VisitArg_list([NotNull] floeParser.Arg_listContext context)
        {
            return base.VisitArg_list(context);
        }

        public override List<IStatement> VisitAssign_statement([NotNull] floeParser.Assign_statementContext context)
        {
            AssignStatement statement = new AssignStatement();

            statement.RegisterName = context.NAME().GetText();
            statement.Value = context.INT_LITERAL().GetText();

            return new List<IStatement>() { statement };
        }

        public override List<IStatement> VisitBlock_condition([NotNull] floeParser.Block_conditionContext context)
        {
            return base.VisitBlock_condition(context);
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
            string outputName = context.NAME().GetText();
            context.
        }

        public override List<IStatement> VisitNode([NotNull] floeParser.NodeContext context)
        {
            return base.VisitNode(context);
        }

        public override List<IStatement> VisitNode_name([NotNull] floeParser.Node_nameContext context)
        {
            return base.VisitNode_name(context);
        }

       
        public override List<IStatement> VisitSource([NotNull] floeParser.SourceContext context)
        {
            return base.VisitSource(context);
        }

        public override List<IStatement> VisitValue([NotNull] floeParser.ValueContext context)
        {
            return base.VisitValue(context);
        }
    }
}
