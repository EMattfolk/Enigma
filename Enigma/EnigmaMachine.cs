using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class EnigmaMachine
    {
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private int rotorPosition, prevLength;
        private Rotor[] rotors;
        private Rotor rotor1, rotor2, rotor3;
        private Reflector reflector;
        private Plugboard plugboard;
        private Dictionary<char, int> alphaToNumber;

        public EnigmaMachine ()
        {
            rotors = new Rotor[] {
                new Rotor(new int[] { 18, 25, 4, 24, 1, 2, 14, 10, 0, 11, 12, 8, 3, 20, 23, 7, 16, 21, 13, 15, 5, 22, 9, 17, 19, 6 }),
                new Rotor(new int[] { 7, 25, 2, 24, 11, 10, 13, 12, 9, 20, 16, 22, 6, 5, 4, 15, 19, 14, 23, 1, 0, 17, 21, 3, 18, 8 }),
                new Rotor(new int[] { 21, 9, 3, 19, 22, 13, 11, 15, 10, 2, 17, 18, 23, 12, 6, 16, 4, 0, 7, 8, 14, 5, 24, 25, 1, 20 }),
                new Rotor(new int[] { 18, 21, 24, 3, 10, 7, 16, 22, 9, 14, 25, 0, 8, 2, 17, 11, 19, 1, 5, 12, 15, 23, 6, 4, 13, 20 }),
                new Rotor(new int[] { 21, 10, 18, 0, 17, 4, 9, 5, 22, 23, 20, 1, 8, 13, 19, 3, 6, 16, 7, 14, 25, 2, 24, 12, 15, 11 })
            };
            rotor1 = rotors[0];
            rotor2 = rotors[1];
            rotor3 = rotors[2];

            reflector = new Reflector(new int[] { 19, 1, 17, 7, 16, 13, 9, 0, 15, 8, 14, 22, 10, 18, 4, 5, 12, 20, 24, 21, 3, 2, 11, 23, 6, 25 });

            plugboard = new Plugboard();

            alphaToNumber = new Dictionary<char, int>();
            foreach (char letter in alphabet)
            {
                alphaToNumber[letter] = alphabet.IndexOf(letter);
            }

            rotorPosition = 0;
            prevLength = 0;
        }

        public string Translate (string input)
        {
            string result = "";
            rotorPosition -= prevLength;
            input = input.ToUpper();

            foreach (char letter in input)
            {
                if (!alphabet.Contains(letter)) continue;
                    
                int charValue = alphaToNumber[letter];

                charValue = plugboard.Pass(charValue);
                charValue = rotor1.Forward(charValue, RotorPosition1());
                charValue = rotor2.Forward(charValue, RotorPosition2());
                charValue = rotor3.Forward(charValue, RotorPosition3());
                charValue = reflector.Reflect(charValue);
                charValue = rotor3.Backward(charValue, RotorPosition3());
                charValue = rotor2.Backward(charValue, RotorPosition2());
                charValue = rotor1.Backward(charValue, RotorPosition1());
                charValue = plugboard.Pass(charValue);

                result += alphabet[charValue];
                rotorPosition++;
            }

            prevLength = result.Length;
            return result;
        }

        public void SetRotorPosition (int rotor3, int rotor2, int rotor1)
        {
            rotorPosition = rotor3 * 26 * 26 + rotor2 * 26 + rotor1;
        }

        public int RotorPosition1 ()
        {
            return mod(rotorPosition, 26);
        }

        public int RotorPosition2()
        {
            return mod(rotorPosition, 676) / 26;
        }

        public int RotorPosition3()
        {
            return mod(rotorPosition, 17576) / 676;
        }

        public void SetRotor1 (int value)
        {
            rotor1 = rotors[value];
        }

        public void SetRotor2(int value)
        {
            rotor2 = rotors[value];
        }

        public void SetRotor3(int value)
        {
            rotor3 = rotors[value];
        }

        public void AddPlugboardConnection (string first, string second)
        {
            plugboard.AddConnection(first, second);
        }

        public void RemovePlugboardConnection (string connection)
        {
            plugboard.RemoveConnection(connection);
        }

        public List<string> GetPlugboardConnections ()
        {
            return plugboard.GetConnections();
        }

        private int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}
