using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursovaa
{
    public class Linked:Base<Linked>
    {
        private Guid _subjectsId;
        public Subjectc Subjectc
        {
            get { return Subjectc.It[_subjectsId]; }
            set { _subjectsId = value.Id; }
        }
        private Guid _timeId;
        public time times
        {
            get { return time.It[_timeId];}
            set { _timeId = value.Id; }
        }
        public static void RefreshLinked(ListBox LB,ListBox LB2)
        {
            LB.DataSource = null;
            if (LB2.SelectedItem != null)
            {
                LB.DataSource = ((Subjectc)LB2.SelectedItem).times;

            }
            

        }
        public static void Separate(ListBox LB1,ListBox LB2,ListBox LB3)
        {

            var s = (Subjectc)LB1.SelectedItem;
            var t = (time)LB2.SelectedItem;
            Linked del = Linked.It.Values.Where(l => l.Subjectc == s && l.times == t).FirstOrDefault(); ;
            if (del != null)
            {
                Linked.It.Remove(del.Id);
                Linked.RefreshLinked(LB3, LB1);
            }

        }
        public static void Unite(ListBox LB1, ListBox LB2, ListBox LB3)
        {
            var s = (Subjectc)LB1.SelectedItem;
            var t = (time)LB2.SelectedItem;
            
              var ex = Linked.It.Values.Where(l => l.Subjectc == s && l.times == t).FirstOrDefault();
            if (ex == null)
                new Linked() { Subjectc = (Subjectc)LB1.SelectedItem, times = (time)LB2.SelectedItem };
            Linked.RefreshLinked(LB3, LB1);
        }

    }
}
