using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRollAssignment
{
    public class Die
    {
        private readonly int _value;
        public int Value => _value;

        public Die(Random random)
        {
            _value = random.Next(1, 7);
        }
    }
}
