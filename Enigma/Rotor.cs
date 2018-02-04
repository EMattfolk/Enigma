using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Rotor
    {
        private int[] forwardConfig, backwardConfig;
        
        public Rotor (int[] config)
        {
            forwardConfig = config;
            backwardConfig = new int[26];
            for (int i = 0; i < 26; i++)
            {
                backwardConfig[forwardConfig[i]] = i;
            }
        }

        public int Forward (int input, int offset)
        {
            return mod(forwardConfig[mod(input + offset, 26)] - offset, 26);
        }

        public int Backward (int input, int offset)
        {
            return mod(backwardConfig[mod(input + offset, 26)] - offset , 26);
        }

        private int mod (int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}
