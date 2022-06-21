using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursovaa
{
    public class time:Base<time>
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public List<Linked> Linkeds
        {
            get
            {
                return Linked.It.Values.Where(l => l.times== this).ToList();
            }

        }
        public List<Subjectc> Subjectcs
        {
            get
            {
                return Linked.It.Values.Where(l => l.times == this).Select(l=>l.Subjectc).ToList();
            }

        }
    }
}
