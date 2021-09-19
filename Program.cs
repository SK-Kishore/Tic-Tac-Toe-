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
            //User Selection and player Selection Fields ;
            int player = 2;
            int userInput = 1;
            bool inputIsCorrect = true;

            //we need to specify which player should play;
            setField();
            do
            {
                if (player == 2)
                {
                    player = 1;
                    DetermineXorO(userInput, player);
                }
                else if (player == 1)
                {
                    player = 2;
                    DetermineXorO(userInput, player);
                }


            } while (true);

        }

        //method for determining userEntered Value 
        public static void DetermineXorO(int userInput, int player)
        {
            char playerSigns = ' ';
            if (player == 1)
            {
                playerSigns = 'X';
            }
            else if (player == 2)
            {
                playerSigns = 'O';
            }
            switch (userInput)
            {
                //User Press 1
                case 1:
                    playerFeilds[0, 0] = playerSigns;
                    break;
                //user Press 2
                case 2:
                    playerFeilds[0, 1] = playerSigns;
                    break;
                //user Press 3
                case 3:
                    playerFeilds[0, 2] = playerSigns;
                    break;
                //user Press 4
                case 4:
                    playerFeilds[1, 0] = playerSigns;
                    break;
                //user Press 5
                case 5:
                    playerFeilds[1, 1] = playerSigns;
                    break;
                //user Press 6
                case 6:
                    playerFeilds[1, 2] = playerSigns;
                    break;
                //user Press 7
                case 7:
                    playerFeilds[2, 0] = playerSigns;
                    break;
                //user Press 8
                case 8:
                    playerFeilds[2, 1] = playerSigns;
                    break;
                //user Press 9
                case 9:
                    playerFeilds[2, 2] = playerSigns;
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!");
                    break;
            }


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
