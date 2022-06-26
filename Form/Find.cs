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
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }
        int y;
        public int TN
        {
            get { return y; }
            set { y = value; }

        }
        public string TN1
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void Find_Load(object sender, EventArgs e)
        {
         
            if (y == 1)
            {
                int p1 = 1;
                bool prov = false;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Сім'я" && l.Data== "2020" &&l.Name == "Подорожі"))
                {
                    
                    
                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov ==false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 2)
            {
                int p1 = 1;
                bool prov = false;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Сім'я" && l.Data == "2019" && l.Name == "Подорожі"))
                {

                   
                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov ==false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 3)
            {
                int p1 = 1;
                bool prov = false;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Сім'я" && l.Data == "2021" && l.Name == "Подорожі"))
                {

                   
                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = " за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 4)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Сім'я" && l.Data == "2022" && l.Name == "Подорожі"))
                {

                   
                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov ==false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 5)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Сім'я" && l.Data == "2020" && l.Name == "Новий Рік"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 6)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Сім'я" && l.Data == "2019" && l.Name == "Новий Рік"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "нажаль, за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 7)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Сім'я" && l.Data == "2021" && l.Name == "Новий Рік"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 8)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Сім'я" && l.Data == "2022" && l.Name == "Новий Рік"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 9)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Сім'я" &&  l.Name == "Новий Рік"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 10)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Сім'я" && l.Name == "Подорожі"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y ==11)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Школа" && l.Data == "2020" && l.Name == "Хімія"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 12)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Школа" && l.Data == "2019" && l.Name == "Хімія"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 13)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Школа" && l.Data == "2021" && l.Name == "Хімія"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 14)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Школа" && l.Data == "2022" && l.Name == "Хімія"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }

            }
            else if (y == 15)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Школа" && l.Data == "2020" && l.Name == "Перший звоник"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {

                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 16)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Школа" && l.Data == "2019" && l.Name == "Перший звоник"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 17)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Школа" && l.Data == "2021" && l.Name == "Перший звоник"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }

            }
            else if (y == 18)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Школа" && l.Data == "2022" && l.Name == "Перший звоник"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 19)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Школа"  && l.Name == "Перший звоник"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
            }
            else if (y == 20)
            {
                bool prov = false;
                int p1 = 1;
                foreach (var i in Photo.It.Values.Where(l => l.albums.Name == "Школа"  && l.Name == "Хімія"))
                {


                    if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1, i); p1++; }
                    else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox2, i); p1++; }
                    else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox3, i); p1++; }
                    else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox4, i); p1++; }
                    else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox5, i); p1++; }
                    else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox6, i); p1++; }
                    else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox7, i); p1++; }
                    else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox8, i); p1++; }
                    else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox9, i); p1++; }
                    else if (p1 == 10) { Photo.Inform(label20, label21, pictureBox10, i); p1++; }
                    else if (p1 == 11) { Photo.Inform(label22, label23, pictureBox11, i); p1++; }
                    prov = true;
                }
                if (prov == false)
                {
                    label1.Text = "за вибраними критеріями фотографій в цьому альбомі не найдено";
                }
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
            F.OpenPicture(this.pictureBox1.Image);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox1.Image);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox1.Image);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox1.Image);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox1.Image);
        }
    }
}
