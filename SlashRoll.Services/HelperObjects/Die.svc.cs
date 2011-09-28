using System;

namespace SlashRoll.Services.HelperObjects
{
    public class Die
    {
        private int _sides;

        public Die(int sides)
        {
            _sides = sides;
        }

        public int roll()
        {
            return new Random().Next(1, _sides);
        }
    }
}