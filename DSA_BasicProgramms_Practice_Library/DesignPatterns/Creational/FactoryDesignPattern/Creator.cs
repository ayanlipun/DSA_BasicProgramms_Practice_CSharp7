namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.FactoryDesignPattern
{
    public abstract class Creator
    {
        public Creator()
        {
            Console.WriteLine("Creator Abstract Execution!!");
        }
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Creator :  The same creator has just worked with " + product.Operation();

            return result;
        }
    }


    class ConcreateCreatorA : Creator
    {
        public ConcreateCreatorA()
        {
            Console.WriteLine("ConcreateCreatorA  instance creation!!");
        }

        public override IProduct FactoryMethod()
        {
            return new ConcreateProdcutA();
        }
    }

    class ConcreateCreatorB : Creator
    {
        public ConcreateCreatorB()
        {
            Console.WriteLine("ConcreateCreatorB  instance creation!!");
        }
        public override IProduct FactoryMethod()
        {
            return new ConcreateProdcutB();
        }
    }
}
