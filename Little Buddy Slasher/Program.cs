using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Buddy_Slasher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Game gameStart = new Game();
                gameStart.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }            
        }
    }
}
