using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPostMock
{
    class Post
    {
        public int VoteCount { get; private set; } = 0;
        public string Title { get; set; }
        public DateTime Created { get; private set; }

        public Post()
        {
            Created = DateTime.Now;
        }

        public Post(string name)
           :this()
        {
            Title = name;
        }

        public void UpVote()
        {
            VoteCount++;
        }

        public void downVote()
        {
            VoteCount--;
        }
    }
}
