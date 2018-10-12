namespace InterfacePolymorphisms
{
    public class Die : IAction
    {
        public void Execute()
        {
            System.Console.WriteLine("You are burnt to bones and ash, game over.");
        }
    }
}
