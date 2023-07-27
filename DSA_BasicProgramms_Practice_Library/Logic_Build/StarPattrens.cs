namespace DSA_BasicProgramms_Practice_Library.Logic_Build
{
    public class StarPattrens
    {

        /*
         Programm make * pattrens as below
              *
              **
              ***
              ****
              *****         
         */
        public static void GetLeftSidedTrianglePattern(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = row; col <= row; col++)
                {
                    Console.Write("*");
                }
                for (int col = 1; col <= number; col++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }


        /*
        Programm make * pattrens as below
                    *
                   **
                  ***
                 ****
                *****
        */
        public static void GetRightSidedTrianglePattern(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(" ");
                }
                for (int col = row; col <= number; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        /*
       Programm to make * pattrens as below
                   *
                  ***
                 *****
                *******
               *********
       */
        public static void GetPyramidPattern(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(" ");
                }
                for (int col = row; col <= number; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /*         
           Programm to make * pattrens as below
                   *
                   *#
                   ***
                   ****#
                   ******         
        */

        public static void StarPattren1()
        {
            Console.WriteLine("Enter the input");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < input; row++)
            {
                for (int col = 0; col < input; col++)
                {
                    if (row % 2 == 0)
                    {
                        if (col == row - 1)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }
        }

        /*
         
         * 
         Programm to make * pattrens as below
                 *****
                 ****
                 ***
                 **
                 *         
         */

        public static void StarPattren2()
        {
            Console.WriteLine("Enter the input");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = input; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
