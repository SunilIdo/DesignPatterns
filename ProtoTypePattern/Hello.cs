using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypePattern
{
    public class Hello:XboxGame
    {
        public Hello(string title)
        {
            Title = title;
        }

        public override XboxGame Clone()
        {
            return (Hello)this.MemberwiseClone();
        }
    }
}
