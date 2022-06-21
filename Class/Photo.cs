using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursovaa
{
    public class Photo
    {
        public Image image;
        public string Data { get; set; }
        public string Geo { get; set; }

        public static List<Photo> photos;
        public Photo() { }
        public Photo(string data,string geo)
        {
            this.Data = data;
            this.Geo = geo;
        }
        public static void AddPicture(PictureBox pb,Label LB1,Label LB2, Photo p1)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb.Image = new Bitmap(ofd.FileName);
                LB2.Text = p1.Data;
                LB1.Text = p1.Geo;
            }
        }
      
        public static void Inform(Label LB1,Label LB2,Photo P1)
        {
            LB1.Text = P1.Data;
            LB2.Text = P1.Geo;
        }
        public static void SaveFile(string path,string text1)
        {
            using (StreamWriter s = File.AppendText(path))
            {
                s.WriteLine(text1);
            }
        }
       
        

        public static string TextOfPhoto(Label LB,Label LB1)
        {
           return $"Місце : " + LB.Text + " " + " Дата: " + LB1.Text;
        }
        public static void AddPicturesOfInform(Label LB,PictureBox PB,string file)
        {
            if (!string.IsNullOrEmpty(LB.Text))
            {
                PB.Image = Image.FromFile(file);
            } 
        }
      
    }
}
