using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Start game by running code (F5)

namespace Game1
{
    class Story
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Allison is a 24, never went to college, and has three cats.");
            Console.WriteLine();
            Console.WriteLine("It's 8am and she wakes up with a hangover from a late night spent watching Netflix and sipping on box wine.");
            Console.WriteLine();
            Console.WriteLine("Should she call in sick or go to work?");
            Console.WriteLine("[press '1' for sick or '2' for work and 'enter' to confirm]");
            Console.WriteLine();

            string chose = Console.ReadLine();
            int decision = Convert.ToInt32(chose);
            Console.WriteLine();

            if (decision == 1)
            {
                Console.WriteLine("Allison reaches for her phone and starts to scroll through her contacts as she practices her sick voice.");
                Console.WriteLine("[press 'enter' to continue for all remaining entries]");
            }

            else
            {
                Console.WriteLine("Allsion reaches for some Advil and downs a few pills.");
                Console.WriteLine("[press 'enter' to continue for all remaining entries]");
            }

            Console.ReadLine();
            Console.WriteLine(".");

            Console.ReadLine();
            Console.WriteLine("..");

            Console.ReadLine();
            Console.WriteLine("...");

            Console.ReadLine();

            Console.WriteLine("Before Allison could get out of bed an intergalactic wormhole opens and the old gods destroy humanity.");
            Console.WriteLine();
            Console.WriteLine("And in humanities final moments one of the Earth's greatest champions proclaims, \"Mondays, am I right?\"");

            Console.ReadLine();

            Console.WriteLine("Thanks for playing. ;-;");

            Console.ReadLine();
        }
    }
}
