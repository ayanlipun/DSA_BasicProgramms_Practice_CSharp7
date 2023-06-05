namespace DSA_BasicProgramms_Practice_Library
{
    public class ReverseWordOfSentence
    {
        public void ReverseWordInAString()
        {
            Console.WriteLine("Enter a string :");
            string input = Console.ReadLine();

            Stack<char> charStack = new Stack<char>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    charStack.Push(input[i]);
                }
                else
                {
                    while (charStack.Count > 0)
                    {
                        Console.Write(charStack.Pop());
                    }
                    Console.Write(" ");
                }
            }
            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }
            Console.ReadKey();
        }
    }
}
