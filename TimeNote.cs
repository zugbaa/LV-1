using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_1
{
    class TimeNote : Note
    {
        private DateTime time;

        public TimeNote(DateTime time, string text, string author, int importance) : base(text, author, importance)
        {
            this.time = time;
        }

        public DateTime Time {
            get { return this.time; }
            set { this.time = value; }

        }

        public override string ToString()
        {
            return base.ToString() + ", " + "time: " + this.time;
        }

    }
}
