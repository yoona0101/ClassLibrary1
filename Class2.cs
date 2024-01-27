using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaemonAtribute
{
    public class BrainValidationAttribute : System.Attribute    {
        public int Brain { get; set; }
        public BrainValidationAttribute() { }
        public BrainValidationAttribute(int brain) { Brain = brain; }
    }
    public class KindValidationAttribute : System.Attribute 
    { public int Brain { get; set; } }
}
