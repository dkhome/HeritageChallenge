namespace Challenge
{
    /*
        You live in the city of Cartesia where all roads are laid out in a perfect grid.
        You arrived ten minutes too early to an appointment,
        so you decided to take the opportunity to go for a short walk.

        The city provides its citizens with a Walk Generating App on their phones
        -- every time you press the button it sends you an array of one-letter strings
        representing directions to walk (eg. ['n', 's', 'w', 'e']).
        You always walk only a single block for each letter (direction) and
        you know it takes you one minute to traverse one city block,
        so create a function that will return true if the walk the app gives
        you will take you exactly ten minutes (you don't want to be early or late!)
        and will, of course, return you to your starting point.
        Return false otherwise.

        Note: you will always receive a valid array containing a random assortment
        of direction letters ('n', 's', 'e', or 'w' only).
        It will never give you an empty array
        (that's not a walk, that's standing still!).
     */
    public class Excercise2
    {
        private const int time = 10;


        private Dictionary<char, int> movements = new Dictionary<char, int>
        {
            {'w', -1 },
            {'e', 1 },
            {'s', -1 },
            {'n', 1 }
        };

        /// <summary>
        /// Coordinates class
        /// </summary>
        private class Coord
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        //I can of course not use Coords class, just check ballance between west/east and north/south
        public bool Solution(char[] path)
        {
            if(path == null)//we can throw an argument exception here
                return false;

            if(path.Length != time)
                return false;

            //distances from original point
            var coords = new Coord();

            foreach (var step in path)
            {
                var movement = movements[step];
                if (step == 'w' || step == 'e')
                    coords.X += movement;
                else
                    coords.Y += movement;
            }

            //we are on the same place
            return coords.X == 0 && coords.Y == 0;
        }
    }



    
}
