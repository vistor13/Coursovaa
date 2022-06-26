using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursovaa
{
     public class Subjectc : Base<Subjectc>
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
                List<Linked> result = new List<Linked>();
                    foreach(var i in Linked.It.Values)
                {
                    if (i.Subjectc == this)
                        result.Add(i);
                }
                return result;
            } 
        }
        public List<time> times
        {
            get
            {
                return Linked.It.Values.Where(l => l.Subjectc == this).Select(l=>l.times).ToList();
            }
        }
        public static void RefreshihgSubjectc(ListBox LB)
        {
            LB.DataSource = null;
            LB.DataSource = Subjectc.It.Values.ToList();
        }
        public static void Delete(ListBox LB)
        {
            Subjectc.It.Remove(((Subjectc)LB.SelectedItem).Id);
        }
        public static void AddSub(TextBox TB)
        {
            new Subjectc() { Name = TB.Text };
        }
    }
}
