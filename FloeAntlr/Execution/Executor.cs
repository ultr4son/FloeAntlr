using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Execution
{
    public static class Executor
    {        
        private static bool DoStep(ExecutionState state)
        {
            //Apply register values to all dependents
            List<RegisterNode> activeRegisters = state.Registers.Where(r => r.IsActive()).ToList();
            
            if(activeRegisters.Count == 0)
            {
                return false;
            }

            activeRegisters.ForEach(r => r.Apply());

            //Perform computation
            state.ExecutionNodes.ForEach(e => e.Apply());

            return true;
        }

        public static void Execute(ExecutionState state)
        {
            while(DoStep(state)) { };
        }
    }
}
