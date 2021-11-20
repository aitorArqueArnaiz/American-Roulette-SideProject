using System;
using System.Collections.Generic;

namespace Game.Domain.model
{
    public class Roulette
    {
        public Dictionary<string, Slide> roulette = new Dictionary<string, Slide>() { { "00" , new Slide("3", "red") }, { "01", new Slide("6", "blue") } };

        public class Slide
        {
            public Slide(string value, string color)
            {
                this.value = value;
                this.color = color;
            }

            public string value { get; set; }
            public string color { get; set; }
        }
    }
}
