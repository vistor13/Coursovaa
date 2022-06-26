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
            Linked.Unite(listSubject2, listTime2, lbLinked2);
            Linked.RefreshLinked(lbLinked2, listSubject2);

        }
       

        private void btdislinked2_Click(object sender, EventArgs e)
        {
            Linked.Separate(listSubject2, listTime2, lbLinked2);
            Linked.RefreshLinked( lbLinked2, listSubject2);
        }

        private void SecondAlbumForm_Load(object sender, EventArgs e)
        {
            listSubject2.DataSource = Subjectc.It.Values.ToList();
            listTime2.DataSource = time.It.Values.ToList();
        }

        private void btAdd2_Click(object sender, EventArgs e)
        {
            Subjectc.AddSub(textBox1);
            Subjectc.RefreshihgSubjectc(listSubject2);
            Linked.RefreshLinked(lbLinked2, listSubject2);
        }

        private void btdelet2_Click(object sender, EventArgs e)
        {
            Subjectc.Delete(listSubject2);
            Subjectc.RefreshihgSubjectc(listSubject2);
        }

        private void btedit2_Click(object sender, EventArgs e)
        {
            ((Subjectc)listSubject2.SelectedItem).Name = textBox1.Text;
            Subjectc.RefreshihgSubjectc(listSubject2);
        }

        private void btsearch1_Click(object sender, EventArgs e)
        {
            var v1 = (Subjectc)listSubject2.SelectedItem;
            string v3 = lbLinked2.Text;


            if (v1.Name == "Подорожі" || v1.Name == "Новий Рік")
            {
                WrongName nt = new WrongName();
                nt.TN = "нажаль, за вибраними критеріями фотографій в цьому альбомі не найдено";
                nt.ShowDialog();
            }
            else if (v1.Name != "Хімія" || v1.Name != "Перший звоник" || v1.Name != "Подорожі" || v1.Name != "Новий Рік")
            {
                WrongName nt = new WrongName();
                nt.TN = "нажаль, за вибраними критеріями фотографій в цьому альбомі не найдено";
                nt.ShowDialog();
            }
            else if (v1.Name == "Хімія" && v3 == "2020")
            {
                int y11 = 11;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Хімія" && v3 == "2019")
            {
                int y11 = 12;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Хімія" && v3 == "2021")
            {
                int y11 = 13;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Хімія" && v3 == "2022")
            {
                int y11 = 14;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Перший звоник" && v3 == "2020")
            {
                int y11 = 15;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Перший звоник" && v3 == "2019")
            {
                int y11 = 16;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Перший звоник" && v3== "2021")
            {
                int y11 = 17;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Перший звоник" && v3 == "2022")
            {
                int y11 = 18;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Перший звоник" && v3 == "")
            {
                int y11 = 19;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Хімія" && v3 =="")
            {
                int y11 = 20;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
        }

        private void listSubject2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSubject2.SelectedItem != null)
            {
                textBox1.Text = ((Subjectc)listSubject2.SelectedItem).Name;
                label7.Text = ((Subjectc)listSubject2.SelectedItem).Name;
            }
            Linked.RefreshLinked(lbLinked2, listSubject2);
        }
        
    }
}
