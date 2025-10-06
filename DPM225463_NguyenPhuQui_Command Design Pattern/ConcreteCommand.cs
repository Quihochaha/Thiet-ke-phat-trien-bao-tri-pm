using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225463_NguyenPhuQui_Command_Design_Pattern
{
    public class ConcreteCommand : Command
    {
        
        public ConcreteCommand(Receiver receiver) :
            base(receiver)
        {
        }
        public override void Execute()
        {
            receiver.Action();
        }
    }
}
