using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        public class Player
        {
            public string name;
            public Player next = null;

            public Player(string name)
            {
                this.name = name;
            }
        }



        static void Main(string[] args)
        {
            Class1.buscabinaria();
            Class1.morte();


            Player player1 = new Player("John");
            Player player2 = new Player("Paul");
            Player player3 = new Player("Logan");
            Player player4 = new Player("James");

            player1.next = player2;
            player2.next = player3;
            player3.next = player4;

            Player currentplayer = player1;

            while (currentplayer != null)
            {
                Console.WriteLine(currentplayer.name);
                currentplayer = currentplayer.next;
            }
            Console.ReadKey();
        }
    }
}
