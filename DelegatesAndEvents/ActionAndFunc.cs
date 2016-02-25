using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    static class ActionAndFunc
    {
        public static void DisplayPreparedMessage()
        {
            Console.WriteLine("Prepared message");
        }

        public static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Set color of console text.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            // Restore color.
            Console.ForegroundColor = previous;
        }

        public static String hello(String firstName, String lastName, int age)
        {
            if (age < 18)
            {
                return String.Format("Hello {0} {1}! You are too young!", firstName, lastName);
            }
            else if ((age > 17) && (age < 50))
            {
                return String.Format("Hello {0} {1}! You are grown up!", firstName, lastName);
            }
            else if (age > 49)
            {
                return String.Format("Hello {0} {1}! You are mature person!", firstName, lastName);
            }
            else
            {
                return String.Format("Hello {0} {1}! You are not a human!", firstName, lastName);
            }
        }
    }
}
