using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assistant
{
    class Player
    {
        private string name;
        private int init;
        private string effect;

        public Player(string name)
        {
            setName(name);
            setInit(0);
            setEffect("none");
        }

        public Player(string name, int init, string effect)
        {
            setName(name);
            setInit(init);
            setEffect(effect);
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getInit()
        {
            return this.init;
        }

        public void setInit(int init)
        {
            this.init = init;
        }

        public string getEffect()
        {
            return this.effect;
        }

        public void setEffect(string effect)
        {
            this.effect = effect;
        }
    }
}
