using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        public void SnakeAndLadder()
        {

            Random diceroll = new Random(); 
            int dice =diceroll.Next(1, 7);
            Console.WriteLine(" Player roll the dice and the number is :" + dice);

        }
    }
  
}              