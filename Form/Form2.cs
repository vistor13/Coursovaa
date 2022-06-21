using System;
using System.Drawing;
using System.Windows.Forms;

namespace Coursovaa
{
    public partial class Form2 : Form
    {
        public string TXT
        {
            get { return AddLabel1.Text; }
            set { AddLabel1.Text = value; }
        }
        public string NMR
        {
            get { return label7.Text; }
            set { label7.Text = value;}
        }
        public string DOP
        {
            get { return labelAdd.Text; }
            set { labelAdd.Text = value; }
        }
        
        internal void AddPictureForBackGround(Image img)
        {
            Image iOld = this.pictureBoxAdd1.Image;
            this.pictureBoxAdd1.Image = (Image)img.Clone();
            if (iOld != null)
                iOld.Dispose();
        }
        internal void AddPictureForInform(Image img)
        {
            Image iOld = this.pictureBox3.Image;
            this.pictureBox3.Image = (Image)img.Clone();
            if (iOld != null)
                iOld.Dispose();
        }
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int p = 1;
            if(p==1)
            {
                FormAddALBUM FormAddal = new FormAddALBUM();
                FormAddal.Show();
                this.Close();
            }
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            var name1 = new Album() { Name = "Сім'я" };
            label1.Text = name1.Name;
            var name2 = new Album() { Name = "Школа" };
            label3.Text = name2.Name;
            var val1 = new Album() { valuesofphoto = "12" };
            label2.Text =val1.valuesofphoto;
            var val2 = new Album() { valuesofphoto = "8" };
            label4.Text = val2.valuesofphoto;
            var dat1 = new Album() { Data = "19.05.2019" };
            label8.Text = dat1.Data;
            var dat2 = new Album() { Data = "13.10.2020" };
            label9.Text = dat2.Data;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            photo1 p = new photo1();
            Album.OpenAlbum(p);

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            photo1_2cs p = new photo1_2cs();
         Album.OpenAlbum(p);
        }
        private void pictureBoxAdd1_Click(object sender, EventArgs e)
        {
            photo2 ph = new photo2();
            Album.OpenAlbum(ph);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            FormInformAlbum FI = new FormInformAlbum();
            FI.TN = this.label1.Text;
            FI.TV = this.label2.Text;
            FI.DT = this.label8.Text;
            FI.ShowDialog();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            FormInformAlbum FI2 = new FormInformAlbum();
            FI2.TN = this.label3.Text;
            FI2.TV = this.label4.Text;
            FI2.DT = this.label9.Text;
            FI2.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormInformAlbum FI2 = new FormInformAlbum();
            FI2.TN = this.AddLabel1.Text;
            FI2.TV = this.label7.Text;
            FI2.DT = this.labelAdd.Text;
            FI2.ShowDialog();
        }
    }
}
