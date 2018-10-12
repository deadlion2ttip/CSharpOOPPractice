using System;

namespace InterfacePolymorphisms
{
    public class Attack : IAction
    {
        public void Execute()
        {
            Console.WriteLine("You attack the Dragon! Your sword bounces off its scales.");
        }
    }
}
