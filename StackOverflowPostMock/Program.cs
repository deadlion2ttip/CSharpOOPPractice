using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPostMock
{
    class Program
    {
        static void Main(string[] args)
        {
            Post catPost = new Post("Cats are Amazing!!!!");

            int i = 0;
            int j = 0;
            while (i < 72)
            {
                catPost.UpVote();
                i++;
            }

            while (j < 12)
            {
                catPost.downVote();
                j++;
            }

            catPost.UpVote();

            Console.WriteLine(catPost.VoteCount);
        }
    }
}
