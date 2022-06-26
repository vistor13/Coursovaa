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
            try
            {
                Linked.Unite(listSubject1, listTime1, lbLinked1);
              
                Linked.RefreshLinked(lbLinked1, listSubject1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btdislinked_Click(object sender, EventArgs e)
        {
            Linked.Separate(listSubject1, listTime1, lbLinked1);
            Linked.RefreshLinked(lbLinked1,listSubject1);
        }

    

        private void btsearch_Click(object sender, EventArgs e)
        {
           
            var v1=(Subjectc)listSubject1.SelectedItem;
            string v3 = lbLinked1.Text;

            if (v1.Name == "Хімія" || v1.Name == "Перший звоник")
            {
                WrongName nt = new WrongName();
                nt.TN = "нажаль, за вибраними критеріями фотографій в цьому альбомі не найдено";
                nt.ShowDialog();
            }
            else if (v1.Name != "Хімія" || v1.Name != "Перший звоник"|| v1.Name != "Подорожі"|| v1.Name != "Новий Рік")
            {
                WrongName nt = new WrongName();
                nt.TN = "нажаль, за вибраними критеріями фотографій в цьому альбомі не найдено";
                nt.ShowDialog();
            }
            else if (v1.Name == "Подорожі" && v3 == "2020")
            {
                int y11 = 1;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
       
            }
            else if (v1.Name == "Подорожі" && v3 == "2019")
            {
                int y11 = 2;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Подорожі" && v3 == "2021")
            {
                int y11 = 3;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Подорожі" && v3 == "2022")
            {
                int y11 = 4;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Новий Рік" && v3 == "2020")
            {
                int y11 = 5;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Новий Рік" && v3 == "2019")
            {
                int y11 = 6;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Новий Рік" && v3 == "2021")
            {
                int y11 = 7;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Новий Рік" && v3 == "2022")
            {
                int y11 = 8;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Новий Рік"&& v3=="")
            {
                int y11 = 9;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
            else if (v1.Name == "Подорожі"&& v3 =="") 
            {
                int y11 = 10;
                Find F = new Find();
                F.TN = y11;
                F.ShowDialog();
            }
           
        }

        private void listTime1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public override string ToString()
        {
            return lbLinked1.Text;
        }
    }
}
