using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225463_NguyenPhuQui_Command_Design_Pattern
{
    public abstract class Command
    {
        protected Receiver receiver;
        // Constructor
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public abstract void Execute();
    }
}
