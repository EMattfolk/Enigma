using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Reflector
    {
        int[] config;

        public Reflector (int[] config)
        {
            this.config = new int[26];
            for (int i = 0; i < 13; i++)
            {
                this.config[config[i * 2]] = config[i * 2 + 1];
                this.config[config[i * 2 + 1]] = config[i * 2];
            }
        }

        public int Reflect(int input)
        {
            return config[input];
        }
    }
}
