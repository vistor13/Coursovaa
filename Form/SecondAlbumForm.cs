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
    public partial class SecondAlbumForm : Form
    {
        public SecondAlbumForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Linked() { Subjectc = (Subjectc)listSubject2.SelectedItem, times = (time)listTime2.SelectedItem };
            UpdateSubject1();
        }
        private void UpdateSubject1()
        {
            listSubject2.DataSource = null;
            listSubject2.DataSource = Subjectc.It.Values.ToList();
        }

        private void btdislinked2_Click(object sender, EventArgs e)
        {
            var s1 = (Subjectc)listSubject2.SelectedItem;
            var t1 = (time)listTime2.SelectedItem;
            var del1 = Linked.It.Values.Where(l => l.Subjectc == s1 && l.times == t1).FirstOrDefault();
            if (del1 != null)
            {
                Linked.It.Remove(del1.Id);
            }
            Update1();
        }

        private void SecondAlbumForm_Load(object sender, EventArgs e)
        {
            listSubject2.DataSource = Subjectc.It.Values.ToList();
            listTime2.DataSource = time.It.Values.ToList();
        }

        private void btAdd2_Click(object sender, EventArgs e)
        {
            new Subjectc() { Name = textBox1.Text };
            UpdateSubject1();
        }

        private void btdelet2_Click(object sender, EventArgs e)
        {
            Subjectc.It.Remove(((Subjectc)listSubject2.SelectedItem).Id);
            UpdateSubject1();
        }

        private void btedit2_Click(object sender, EventArgs e)
        {
            ((Subjectc)listSubject2.SelectedItem).Name = textBox1.Text;
            UpdateSubject1();
        }

        private void btsearch1_Click(object sender, EventArgs e)
        {
            photo2 ph = new photo2();
            ph.ShowDialog();
        }

        private void listSubject2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSubject2.SelectedItem != null)
            {
                textBox1.Text = ((Subjectc)listSubject2.SelectedItem).Name;
            }
            Update1();
        }
        private void Update1()
        {
            lbLinked2.DataSource = null;
            if (listSubject2.SelectedItem != null)
            {
                lbLinked2.DataSource = ((Subjectc)listSubject2.SelectedItem).times;
            }
        }
    }
}
