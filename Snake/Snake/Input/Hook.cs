using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Hook
    {
        private static Hashtable Keys = new Hashtable();

        public static bool KeyDown(Keys key)
        {
            if (Keys[key] == null)
            {
                return false;
            }

            return (bool)Keys[key];
        }

        public static void State(Keys key, bool state)
        {
            Keys[key] = state;
        }
    }
}
