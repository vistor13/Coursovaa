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
    public partial class photo2 : Form
    {
        public photo2()
        {
            InitializeComponent();
        }
        int p = 1;
        string path2 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\info3.txt";
       
        string ph12 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\школа\1.jpg";
        Album n1 = new Album();
        private void button1_Click(object sender, EventArgs e)
        {
            Photo photo1 = new Photo() { Data = "2020", Geo = "Київ",albums=n1 };
            Photo photo2 = new Photo() { Data = "2018", Geo = "Коростень", albums = n1 };
            Photo photo3 = new Photo() { Data = "2022", Geo = "Київ", albums = n1 };
            Photo photo4 = new Photo() { Data = "2019", Geo = "Харків", albums = n1 };
            Photo photo5 = new Photo() { Data = "2022", Geo = "Київ", albums = n1 };
            Photo photo6 = new Photo() { Data = "2017", Geo = "Одеса", albums = n1 };
            Photo photo7 = new Photo() { Data = "2018", Geo = "Коростень", albums = n1 };
            Photo photo8 = new Photo() { Data = "2020", Geo = "Київ", albums = n1 };
            Photo photo9 = new Photo() { Data = "2017", Geo = "Київ",albums=n1 };
            Photo photo10 = new Photo() { Data = "2018", Geo = "Київ", albums = n1 };

            pictureBox21.Image = Image.FromFile( @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\свойства.jpg");
            if (p == 1)
                { 
                    Photo.AddPicture(pictureBox1,label2, label3, photo1);
                    AddPictureForInform(this.pictureBox21.Image, pictureBox11);
                Photo.SaveFile(path2, photo1);
                label1.Text = "В альбомі є фото, дякуєм , що добавили";
                
                    p++;
                }
                else if (p == 2)
                {
                Photo.AddPicture(pictureBox2, label5, label4, photo2);
                AddPictureForInform(this.pictureBox21.Image, pictureBox12);
                Photo.SaveFile(path2, photo2);
        
                p++;
                }
                else if (p == 3)
                {
                Photo.AddPicture(pictureBox3, label7, label6, photo3);
                AddPictureForInform(this.pictureBox21.Image, pictureBox13);
                Photo.SaveFile(path2, photo3);
               
                p++;
                }
                else if (p == 4)
                {
                Photo.AddPicture(pictureBox4, label9, label8, photo4);
                AddPictureForInform(this.pictureBox21.Image, pictureBox14);
                Photo.SaveFile(path2, photo4);
                
                p++;
                }
                else if (p == 5)
                {

                Photo.AddPicture(pictureBox5, label11, label10, photo5);
                AddPictureForInform(this.pictureBox21.Image, pictureBox15);
                Photo.SaveFile(path2, photo5);
           
                p++;
                }
                else if (p == 6)
                {
                Photo.AddPicture(pictureBox6, label13, label18, photo6);
                AddPictureForInform(this.pictureBox21.Image, pictureBox16);
                Photo.SaveFile(path2, photo6);
              
                p++;
                }
                else if (p == 7)
                {
                Photo.AddPicture(pictureBox7, label15, label22, photo7);
                AddPictureForInform(this.pictureBox21.Image, pictureBox17);
                Photo.SaveFile(path2, photo7);
               
                p++;
                }
                else if (p == 8)
                {
                Photo.AddPicture(pictureBox8, label17, label23, photo8);
                AddPictureForInform(this.pictureBox21.Image, pictureBox18);
                Photo.SaveFile(path2, photo8);
                
                p++;
                }
                else if (p == 9)
                {
                Photo.AddPicture(pictureBox9, label19, label24, photo9);
                AddPictureForInform(this.pictureBox21.Image, pictureBox19);
                Photo.SaveFile(path2, photo9);
                
                p++;
                }
                else if (p == 10)
                {
                Photo.AddPicture(pictureBox10, label21, label20, photo10);
                AddPictureForInform(this.pictureBox21.Image, pictureBox20);
                Photo.SaveFile(path2, photo10);
               
                p++;
                }
                else if (p == 11) 
                {
                Wrong p1 = new Wrong();
                p1.ShowDialog();
                }
            

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

        private void photo2_Load(object sender, EventArgs e)
        {

           
        }

        private void btproperties_Click(object sender, EventArgs e)
        {
            FirstAlbumForm p = new FirstAlbumForm();
            Album.OpenAlbum(p);
        }

        internal void AddPictureForInform(Image img,PictureBox PB2)
        {
            Image iOld = PB2.Image;
            PB2.Image = (Image)img.Clone();
            if (iOld != null)
                iOld.Dispose();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label2.Text + " " + " Дата: " + label3.Text;
            fsip.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label5.Text + " " + " Дата: " + label4.Text;
            fsip.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label7.Text + " " + " Дата: " + label6.Text;
            fsip.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label9.Text + " " + " Дата: " + label8.Text;
            fsip.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label11.Text + " " + " Дата: " + label10.Text;
            fsip.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label13.Text + " " + " Дата: " + label12.Text;
            fsip.ShowDialog();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label15.Text + " " + " Дата: " + label14.Text;
            fsip.ShowDialog();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label17.Text + " " + " Дата: " + label16.Text;
            fsip.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label19.Text + " " + " Дата: " + label18.Text;
            fsip.ShowDialog();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label21.Text + " " + " Дата: " + label20.Text;
            fsip.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
