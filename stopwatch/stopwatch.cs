using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    class stopwatch
    {
        private bool _isRunning = false;

        private DateTime _startTime;

        private DateTime _endTime;

        public TimeSpan TimeElapsed
        {
            get { try
                {
                    return _endTime - _startTime;
                }
                catch
                {
                    throw new InvalidOperationException("Must start and stop stopwatch before checking time");
                }
            }
        }

        public void Start()
        {
            if (!_isRunning)
            {
                this._startTime = DateTime.Now;
                Console.WriteLine("Stopwatch started at " + _startTime);
                _isRunning = true;
            }
            else
                throw new InvalidOperationException("stopwatch cannot be started twice in a row");

        }
    }
}
