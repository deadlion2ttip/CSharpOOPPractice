namespace InterfacePolymorphisms
{
    public class Defend : IAction
    {
        public void Execute()
        {
            System.Console.WriteLine("The dragon attacks viciously, but you dodge just in time!");
        }
    }
}
