using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursovaa
{
    public partial class FirstAlbumForm : Form
    {
        public FirstAlbumForm()
        {
            InitializeComponent();
        }
        private void FirstAlbumForm_Load(object sender, EventArgs e)
        { 
            listSubject1.DataSource = Subjectc.It.Values.ToList();
            listTime1.DataSource = time.It.Values.ToList();
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Subjectc.AddSub(textBox1);
            Subjectc.RefreshihgSubjectc(listSubject1);
            Linked.RefreshLinked(lbLinked1, listSubject1);
        }

        private void listSubject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listSubject1.SelectedItem != null)
            {
                textBox1.Text = ((Subjectc)listSubject1.SelectedItem).Name;
                label7.Text = ((Subjectc)listSubject1.SelectedItem).Name;
            }
            Linked.RefreshLinked(lbLinked1, listSubject1);
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            ((Subjectc)listSubject1.SelectedItem).Name = textBox1.Text;
            Subjectc.RefreshihgSubjectc(listSubject1);
        }

        

        private void btdelet_Click(object sender, EventArgs e)
        {
            Subjectc.Delete(listSubject1);
            Subjectc.RefreshihgSubjectc(listSubject1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
              var exist = existing();
                if (exist == null)
                    new Linked() { Subjectc = (Subjectc)listSubject1.SelectedItem, times = (time)listTime1.SelectedItem };
                Linked.RefreshLinked(lbLinked1, listSubject1);
           
        }
        private void btdislinked_Click(object sender, EventArgs e)
        {
                Linked del = existing();
                if (del != null)
                {
                    Linked.It.Remove(del.Id);
                Linked.RefreshLinked(lbLinked1, listSubject1);
            } 
          
        }

        private Linked existing()
        {
            var s = (Subjectc)listSubject1.SelectedItem;
            var t = (time)listTime1.SelectedItem;
            var del = Linked.It.Values.Where(l => l.Subjectc == s && l.times == t).FirstOrDefault();
            return del;
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            
            var exis = existing();
            var sub1 = exis.Subjectc.Name == "Новий Рік";
            var sub2 = exis.Subjectc.Name == "Перший звоник";
            var sub3 = exis.Subjectc.Name == "Подорожі";
            var sub4 = exis.Subjectc.Name == "Хімія";
            var time2 = exis.times.Name == " 2019-2020";
            var time3 = exis.times.Name == " 2020-2022";
            if (exis == null)
            {
                photo1 ph = new photo1();
                ph.ShowDialog();
                this.Close();
            }
            else if (sub1&&time2)
            {
                Wrong p = new Wrong();
                p.ShowDialog();
            }
            else if (sub1&&time2)
            {
                Wrong p = new Wrong();
                p.ShowDialog();
            }
            else if (sub1 &&time3)
            {
                Wrong p = new Wrong();
                p.ShowDialog();
            }
        }
    }
}
