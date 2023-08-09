namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents
{
    public delegate string GreetingDelegate(string name);
    public class LambdaExpressionsForDelegate
    {
        public static void ExecLambdaExpressionsForDelegate()
        {
            GreetingDelegate obj = (name) =>
            {
                return "Hello @" + name + " welcome to Dotnet Tutorials";
            };
            string greetingDelegate = obj.Invoke("WinsomeBasket");
            Console.WriteLine(greetingDelegate);
        }

        public static string Greetings(string name)
        {
            return "Hello @" + name + " welcome to Dotnet Tutorials";
        }
    }
}
