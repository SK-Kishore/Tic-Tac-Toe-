using System;

namespace Basics
{
    class Program
    {
        //makking player Fields by the way we are creating 2 dimensional array;
        static char[,] playerFeilds =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' },
        };


        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            //do
            //{
            //    if (player == 2)
            //    {
            //        player = 1;
            //    }
            //    else
            //    {
            //        player = 2;
            //    }
            //} while (true);



            setField();
        }

        public static void setField()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playerFeilds[0, 0], playerFeilds[0, 1], playerFeilds[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playerFeilds[1, 0], playerFeilds[1, 1], playerFeilds[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playerFeilds[2, 0], playerFeilds[2, 1], playerFeilds[2, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
        }
    }
}
