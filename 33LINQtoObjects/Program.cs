using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _33LINQtoObjectsExt;

namespace _33LINQtoObjects
{
    class StringComparer : IEqualityComparer<String>
    {
        public bool Equals(string x, string y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }
    }

    class CharComparer : IEqualityComparer<Char>
    {

        public bool Equals(char x, char y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(char obj)
        {
            return obj.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QueryOverStrings();
            //QueryOverInts();
            //QueryOverIntUsingVar();
            Console.ReadLine();
        }

        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            IEnumerable<int> anIntSet = from i in numbers
                                        where i > 4 && i < 20
                                        orderby i descending
                                        select i;

            foreach( int i in anIntSet )
            {
                Console.WriteLine(i);
            }
        }

        static void QueryOverIntUsingVar()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            var anIntSet = from i in numbers
                           where i > 4 && i < 20                           
                           orderby i descending
                           select i;

            foreach (var i in anIntSet)
            {
                Console.WriteLine(i);
            }
        }        

        static void QueryOverStrings()
        {
            // Assume we have an array of strings.
            String[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};
            /*
            var res = from i in currentVideoGames
                      where i.Contains("2") orderby i descending
                      select i;
            */

            StringComparer scp = new StringComparer();
            Console.WriteLine("Contains = " + currentVideoGames.Contains("Morrowind", scp));

            CharComparer ccp = new CharComparer();
            IEnumerable<String> res = from i in currentVideoGames
                                      where i.Contains<char>('3',ccp)
                                      select i;
                        
            
            IEnumerable<String> res1 = from i in currentVideoGames
                                       where _33LINQtoObjectsExt.MyExtensions.Contains(i,"2")
                                       select i;            

            //IEnumerable<string> res = currentVideoGames.Where(str => str.Length > 10);

            Console.WriteLine(res.GetType().Name);
            Console.WriteLine(res.GetType().Assembly.Location);

            foreach (String str in res1)
            {
                Console.WriteLine(str);
            }
        }
    }
}
