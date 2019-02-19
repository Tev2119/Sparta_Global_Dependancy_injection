using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Mansion Mn = new Mansion();

            Mn.
        }
        
        public interface architecture
        {
            void numOfBedrooms();
            void doors();
            void swimmingPool();
            void cleaners();
            void windows();
        }
        public class Mansion: architecture
        {
            public void numOfBedrooms()
            {
                Console.WriteLine("i have 6 bedrroms");
            }
            public void doors()
            {
                Console.WriteLine("i have 12 doors");
            }
            public void swimmingPool()
            {
                Console.WriteLine("i have 3 pools");
            }
            public void cleaners()
            {
                Console.WriteLine("i have 4 cleaners");
            }
            public void windows()
            {
                Console.WriteLine("i have 22 cleaners");
            }

        }
        public class Bungalow : architecture
        {
            public void numOfBedrooms()
            {
                Console.WriteLine("i have 2 bedrroms");
            }
            public void doors()
            {
                Console.WriteLine("i have 3 doors");
            }
            public void swimmingPool()
            {
                Console.WriteLine("i have no pools");
            }
            public void cleaners()
            {
                Console.WriteLine("i have no cleaners");
            }
            public void windows()
            {
                Console.WriteLine("i have 4 cleaners");
            }

        }
        public class Flat : architecture
        {
            public void numOfBedrooms()
            {
                Console.WriteLine("i have 3 bedrroms");
            }
            public void doors()
            {
                Console.WriteLine("i have 3 doors");
            }
            public void swimmingPool()
            {
                Console.WriteLine("i have no pools");
            }
            public void cleaners()
            {
                Console.WriteLine("i have 1 cleaners");
            }
            public void windows()
            {
                Console.WriteLine("i have 3 cleaners");
            }

        }
        public class Studio : architecture
        {
            public void numOfBedrooms()
            {
                Console.WriteLine("i have 1 bedrroms");
            }
            public void doors()
            {
                Console.WriteLine("i have 1 doors");
            }
            public void swimmingPool()
            {
                Console.WriteLine("i have no pools");
            }
            public void cleaners()
            {
                Console.WriteLine("i have 1 cleaners");
            }
            public void windows()
            {
                Console.WriteLine("i have 4 cleaners");
            }

        }
        public class PlayBoyMansion : architecture
        {
            public void numOfBedrooms()
            {
                Console.WriteLine("i have 25 bedrroms");
            }
            public void doors()
            {
                Console.WriteLine("i have 50 doors");
            }
            public void swimmingPool()
            {
                Console.WriteLine("i have 15 pools");
            }
            public void cleaners()
            {
                Console.WriteLine("i have 55 cleaners");
            }
            public void windows()
            {
                Console.WriteLine("i have 66 cleaners");
            }

        }
    }
}
