namespace Challenge
{
    public class Excercise1
    {
        /*
            write some code that, giving an array of strings, returns the counter of those items where at least a char is repeated

            ["a","b","c"] -> 0
            ["a","b","cc"] -> 1
            ["ABC","deef","hi", "mnmn"] -> 2
            ["AABBCCDDDDD","123","xyz", "qwertt"] -> 2
            ["123a","1233","11", "tttttxxxxxzzzzz"] -> 3
         */
        public int Solution(string[] input)
        {
            var count = 0;
            if (input == null)
                return count;

            foreach (var word in input)
            { 
                var chars = new HashSet<char>();
                foreach(var ch in word)
                {
                    if(chars.Contains(ch))
                    {
                        count++;
                        break;
                    }
                    chars.Add(ch);
                }
            }

            return count;
        }
    }
}