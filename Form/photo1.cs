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
    public partial class photo1 : Form
    {
        public photo1()
        {
            InitializeComponent();
        }

        int p = 1;
        int p1 = 1;
        string path2 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\info1.txt";
        string file1 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\свойства.jpg";
        Album nn = new Album();
        private void button1_Click(object sender, EventArgs e)
        {
            Photo photo12 = new Photo() { Data = "2019", Geo = "Київ" ,albums=nn};
            Photo photo13 = new Photo() { Data = "2018", Geo = "Київ",albums=nn };
            Photo photo14 = new Photo() { Data = "2020", Geo = "Київ" ,albums=nn};
            Photo photo15 = new Photo() { Data = "2021", Geo = "Київ" ,albums=nn};
            Photo photo16 = new Photo() { Data = "2022", Geo = "Київ",albums=nn };
            if (p == 1)
            { 
                Photo.AddPicture(pictureBox12, label25, label24, photo12);
                Photo.AddPicturesOfInform(label24, pictureBox17, file1);
                Photo.SaveFile(path2 ,photo12);
                p++;
            }
            else if (p == 2)
            {

                Photo.AddPicture(pictureBox13, label27, label26, photo13);
                Photo.AddPicturesOfInform(label26, pictureBox18, file1);

                Photo.SaveFile(path2,photo13);

                p++;

            }
            else if (p == 3)
            {

                Photo.AddPicture(pictureBox14, label29, label28, photo14);
                Photo.AddPicturesOfInform(label28, pictureBox19, file1);
                
                Photo.SaveFile(path2, photo14);

                p++;

            }
            else if (p == 4)
            {

                Photo.AddPicture(pictureBox15, label31, label30, photo15);
                Photo.AddPicturesOfInform(label30, pictureBox20, file1);
             
                Photo.SaveFile(path2, photo14);

                p++;

            }
            else if (p == 5)
            {
                Photo.AddPicture(pictureBox16, label33, label32, photo16);
                Photo.AddPicturesOfInform(label32, pictureBox21, file1);
 
                Photo.SaveFile(path2, photo15);
                p++;
            }
            else if (p == 6)
            {
                Wrong p1 = new Wrong();
                p1.ShowDialog();
            }
                
   
        }
        internal void AddPictureForInform(Image img, PictureBox PB2)
        {
            Image iOld = PB2.Image;
            PB2.Image = (Image)img.Clone();
            if (iOld != null)
                iOld.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox1.Image);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox2.Image);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox3.Image);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox4.Image);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox5.Image);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox6.Image);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox7.Image);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox8.Image);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox15.Image);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox14.Image);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox13.Image);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox16.Image);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox10.Image);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox11.Image);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox9.Image);
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox12.Image);
        }

        private void photo1_Load(object sender, EventArgs e)
        {


            foreach (var i in Photo.It.Values.Where(l => l.albums.Name=="Сім'я"))
            {
                if (p1 == 1) { Photo.Inform(label3, label2,pictureBox1 , i); p1++; }
                else if (p1 == 2) { Photo.Inform(label4, label5,pictureBox2, i); p1++; }
                else if (p1 == 3) { Photo.Inform(label6, label7,pictureBox3, i); p1++; }
                else if (p1 == 4) { Photo.Inform(label8, label9,pictureBox4,  i); p1++; }
                else if (p1 == 5) { Photo.Inform(label10, label11,pictureBox5,  i); p1++; }
                else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6,  i); p1++; }
                else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7,  i); p1++; }
                else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8,  i); p1++; }
                else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10,  i); p1++; }
                else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }

            }
           
        }

        private void bProperties1_Click(object sender, EventArgs e)
        {
            FirstAlbumForm p = new FirstAlbumForm();
            Album.OpenAlbum(p); ;
        }
      
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label2.Text + " " + " Дата: " + label3.Text;
            fsip.ShowDialog();

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label5.Text + " " + " Дата: " + label4.Text;
            fsip.ShowDialog();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label7.Text + " " + " Дата: " + label6.Text;
            fsip.ShowDialog();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label9.Text + " " + " Дата: " + label8.Text;
            fsip.ShowDialog();

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label9.Text + " " + " Дата: " + label8.Text;
            fsip.ShowDialog();

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label13.Text + " " + " Дата: " + label12.Text;
            fsip.ShowDialog();

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label15.Text + " " + " Дата: " + label14.Text;
            fsip.ShowDialog();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label17.Text + " " + " Дата: " + label16.Text;
            fsip.ShowDialog();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label19.Text + " " + " Дата: " + label18.Text;
            fsip.ShowDialog();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label21.Text + " " + " Дата: " + label20.Text;
            fsip.ShowDialog();

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label23.Text + " " + " Дата: " + label22.Text;
            fsip.ShowDialog();

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label25.Text + " " + " Дата: " + label24.Text;
            fsip.ShowDialog();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label27.Text + " " + " Дата: " + label26.Text;
            fsip.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label29.Text + " " + " Дата: " + label28.Text;
            fsip.ShowDialog();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label31.Text + " " + " Дата: " + label30.Text;
            fsip.ShowDialog();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label33.Text + " " + " Дата: " + label31.Text;
            fsip.ShowDialog();
        }

        private void bProperties1_Click_1(object sender, EventArgs e)
        {
            FirstAlbumForm faf = new FirstAlbumForm();
            faf.ShowDialog();
            this.Close();
        }

        private void photo1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

       
    }
}
