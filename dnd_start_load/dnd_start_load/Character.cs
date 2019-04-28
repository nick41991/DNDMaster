using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_start_load
{
    public abstract class Character
    {
        public int init;
        public String name;

        public abstract int getinit();
        public abstract String getName();

    }
}
