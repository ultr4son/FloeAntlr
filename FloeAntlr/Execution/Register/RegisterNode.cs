using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Execution
{
    public abstract class RegisterNode : INode
    {
        private int value;
        public List<INode> dependents;

        public void Fufill(int value)
        {
            this.value = value;
        }

        public virtual void Apply()
        {
            dependents.ForEach(dependent => dependent.Fufill(value));
        }

        public virtual bool IsActive()
        {
            return true;
        }

    }
}
