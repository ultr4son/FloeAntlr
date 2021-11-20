using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Execution.Register
{
    public class RegisterNodeLiteral : RegisterNode
    {
        private bool isActive = true;
        public override void Apply()
        {
            base.Apply();
            isActive = false;
        }
        public override bool IsActive()
        {
            return isActive;
        }
    }
}
