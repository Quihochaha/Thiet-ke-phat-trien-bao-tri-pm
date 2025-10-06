using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225463_NguyenPhuQui_Memento
{
    public class Caretaker
    {
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
