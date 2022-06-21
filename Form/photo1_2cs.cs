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
    public partial class photo1_2cs : Form
    {
        public photo1_2cs()
        {
            InitializeComponent();
        }
        int p = 1;
        private void button1_Click(object sender, EventArgs e)
        {

            Photo photo10 = new Photo("2019", "Київ");
            Photo photo11 = new Photo("2019", "Київ");
            Photo photo12 = new Photo("2019", "Київ");
            Photo photo13 = new Photo("2019", "Київ");
            Photo photo14 = new Photo("2019", "Київ");
            Photo photo15 = new Photo("2019", "Київ");
            Photo photo16 = new Photo("2019", "Київ");
         
            string file1 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\свойства.jpg";
            string path2 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa\bin\Debug\dannie2.txt";

            if (p == 1)
            {
                Photo.AddPicture(pictureBox10, label21, label20, photo10);
                Photo.AddPicturesOfInform(label21, pictureBox31, file1);
                string h = Photo.TextOfPhoto(label21, label20);
                Photo.SaveFile(path2, h);
                p++;
               
            }
            else if (p == 2)
            {
              
                Photo.AddPicture(pictureBox11, label23, label22, photo11);
                Photo.AddPicturesOfInform(label23, pictureBox32, file1);
                string h = Photo.TextOfPhoto(label23, label22);
                Photo.SaveFile(path2, h);
                p++;
               
            }
            else if (p == 3)
            {
               
                Photo.AddPicture(pictureBox12, label25, label24, photo12);
                Photo.AddPicturesOfInform(label25, pictureBox17, file1);
                string h = Photo.TextOfPhoto(label25, label24);
                Photo.SaveFile(path2, h);
                p++;
                
            }
            else if (p == 4)
            {
                
                Photo.AddPicture(pictureBox13, label27, label26, photo13);
                Photo.AddPicturesOfInform(label27, pictureBox18, file1);
                string h = Photo.TextOfPhoto(label27, label26);
                Photo.SaveFile(path2, h);

                p++;
                
            }
            else if (p == 5)
            {
                
                Photo.AddPicture(pictureBox14, label29, label28, photo14);
                Photo.AddPicturesOfInform(label29, pictureBox19, file1);
                string h = Photo.TextOfPhoto(label28, label27);
                Photo.SaveFile(path2, h);

                p++;
                
            }
            else if (p == 6)
            {
                
                Photo.AddPicture(pictureBox14, label31, label30, photo15);

                Photo.AddPicturesOfInform(label31, pictureBox20, file1);
                string h = Photo.TextOfPhoto(label30, label29);
                Photo.SaveFile(path2, h);
                p++;
                
            }
            else if (p == 7)
            {
                
                Photo.AddPicture(pictureBox14, label33, label32, photo16);
                Photo.AddPicturesOfInform(label33, pictureBox21, file1);
                string h = Photo.TextOfPhoto(label32, label33);
                Photo.SaveFile(path2, h);
                p++;
                
            }
            else if (p == 8)
            {
                Wrong w = new Wrong();
                w.ShowDialog();

            }
        }
        private void photo1_2cs_Load(object sender, EventArgs e)
        {
            Photo photo1 = new Photo("2019", "Коростень");
            Photo photo2 = new Photo("2019", "Київ");
            Photo photo3 = new Photo("2019", "Коростень");
            Photo photo4 = new Photo("2019", "Коростень");
            Photo photo5 = new Photo("2019", "Коростень");
            Photo photo6 = new Photo("2019", "Київ");
            Photo photo7 = new Photo("2019", "Коростень");
            Photo photo8 = new Photo("2019", "Коростень");
            Photo photo9 = new Photo("2019", "Коростень");
            
            Photo.Inform(label3, label2, photo1);
            Photo.Inform(label4, label5, photo2);
            Photo.Inform(label6, label7, photo3);
            Photo.Inform(label8, label9, photo4);
            Photo.Inform(label10, label11, photo5);
            Photo.Inform(label12, label13, photo6);
            Photo.Inform(label14, label15, photo7);
            Photo.Inform(label16, label17, photo8);
            Photo.Inform(label18, label19, photo9);
            string path2 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa\bin\Debug\dannie2.txt";
            string h = Photo.TextOfPhoto(label2, label3);
            string h1 = Photo.TextOfPhoto(label5, label4);
            string h2 = Photo.TextOfPhoto(label7, label6);
            string h3 = Photo.TextOfPhoto(label9, label8);
            string h4 = Photo.TextOfPhoto(label11, label10);
            string h5 = Photo.TextOfPhoto(label13, label12);
            string h6 = Photo.TextOfPhoto(label15, label14);
            string h7 = Photo.TextOfPhoto(label17, label16);
            string h8 = Photo.TextOfPhoto(label19, label18);
            Photo.SaveFile(path2, h);
            Photo.SaveFile(path2, h1);
            Photo.SaveFile(path2, h2);
            Photo.SaveFile(path2, h3);
            Photo.SaveFile(path2, h4);
            Photo.SaveFile(path2, h5);
            Photo.SaveFile(path2, h6);
            Photo.SaveFile(path2, h7);
            Photo.SaveFile(path2, h8);


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
            fsip.TN = "Місце : " + label11.Text + " " + " Дата: " + label10.Text;
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
            fsip.TN = "Місце : " + label33.Text + " " + " Дата: " + label32.Text;
            fsip.ShowDialog();
        }
        private void bProperties1_Click(object sender, EventArgs e)
        {
            
            FirstAlbumForm saf = new FirstAlbumForm();
            saf.ShowDialog();
            this.Close();

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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox9.Image);
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

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox12.Image);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox13.Image);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox14.Image);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox15.Image);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox16.Image);
        }
    }
}
