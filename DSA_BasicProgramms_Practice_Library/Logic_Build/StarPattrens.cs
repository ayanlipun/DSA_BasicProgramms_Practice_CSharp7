namespace DSA_BasicProgramms_Practice_Library.Logic_Build
{
    public class StarPattrens
    {
        public void GetLeftSidedTrianglePattern(int number)
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
        public void GetRightSidedTrianglePattern(int number)
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
        public void GetPyramidPattern(int number)
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
    }
}
