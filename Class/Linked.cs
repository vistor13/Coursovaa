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
        
    }
}
