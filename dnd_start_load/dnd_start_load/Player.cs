using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_start_load
{
    public class Player : Character
    {
        private string name;
        private string effect;
        public bool isdead = false;

        public Player(string name)
        {
            setName(name);
            setInit(0);
            setEffect("none");
        }

        public Player(string name, string init)
        {
            setName(name);
            if (!Int32.TryParse(init, out this.init))
            {
                //DIE ROLL
            }
        }

        public Player(string name, string init, string effect)
        {
            setName(name);
            if (!Int32.TryParse(init, out this.init))
            {
                //DIE ROLL
            }
            setEffect(effect);
        }

        public override string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public override int getinit()
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
