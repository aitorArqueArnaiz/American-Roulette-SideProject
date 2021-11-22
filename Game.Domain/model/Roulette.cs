namespace Game.Domain.model
{
    using System.Collections.Generic;

    public static class Roulette
    {
        public static Dictionary<(int, int), Slide> roulette = new Dictionary<(int, int), Slide>() { { (0, 0) , new Slide("3", "red") }, { (0, 1), new Slide("6", "blue") }, { (0, 2), new Slide("9", "red") }, { (0, 3), new Slide("12", "red") }, { (0, 4), new Slide("15", "blue") }, { (0, 5), new Slide("18", "red") }, { (0, 6), new Slide("21", "red") }, { (0, 7), new Slide("24", "blue") }, { (0, 8), new Slide("27", "red") }, { (0, 9), new Slide("30", "red") }, { (0, 10), new Slide("33", "blue") }, { (0, 11), new Slide("36", "red") },
                                                        { (1, 0) , new Slide("2", "blue") }, { (1, 1) , new Slide("5", "red") }, { (1, 2) , new Slide("8", "blue") }, { (1, 3) , new Slide("11", "blue") }, { (1, 4) , new Slide("14", "red") }, { (1, 5) , new Slide("17", "blue") }, { (1, 6) , new Slide("20", "blue") }, { (1, 7) , new Slide("23", "red") }, { (1, 8) , new Slide("26", "blue") }, { (1, 9) , new Slide("29", "blue") }, { (1, 10) , new Slide("32", "red") }, { (1, 11) , new Slide("35", "blue") },
                                                        { (2, 0) , new Slide("1", "red") }, { (2, 1) , new Slide("4", "blue") }, { (2, 2) , new Slide("7", "red") }, { (2, 3) , new Slide("10", "blue") }, { (2, 4) , new Slide("13", "blue") }, { (2, 5) , new Slide("16", "red") }, { (2, 6) , new Slide("19", "red") }, { (2, 7) , new Slide("22", "blue") }, { (2, 8) , new Slide("25", "red") }, { (2, 9) , new Slide("28", "blue") }, { (2, 10) , new Slide("31", "blue") }, { (2, 11) , new Slide("34", "red") }};

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
