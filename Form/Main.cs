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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       
        string path1 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\info1.txt";
        string path2 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\info2.txt";
        string path3= @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\info3.txt";


        private void open_the_album_Click(object sender, EventArgs e)
        {
            Form2 Formopen = new Form2();
            Formopen.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Photo.ReWriteTextFile(path1);
            Photo.ReWriteTextFile(path2);
            Photo.ReWriteTextFile(path3);
            var list1 = new Subjectc() { Name = "Подорожі" };
            var list2 = new Subjectc() { Name = "Новий Рік" };
            var list3 = new Subjectc() { Name = "Перший звоник" };
            var list4 = new Subjectc() { Name = "Хімія" };
            var l = new time() { Name = "2019" };
            var l3 =new time() { Name = "2020" };
            var l1 = new time() { Name = "2021" };
            var l2 = new time() { Name = "2022" };
            
        }
    }
}
