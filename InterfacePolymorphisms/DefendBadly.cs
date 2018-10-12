namespace InterfacePolymorphisms
{
    public class DefendBadly : IAction
    {
        public void Execute()
        {
            System.Console.WriteLine("The dragon pours fire from its mouth, you can't get out of the way in time!");
        }
    }
}
