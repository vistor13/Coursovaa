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
    public partial class FormInformAlbum : Form
    {
        public FormInformAlbum()
        {
            InitializeComponent();
        }
        public string TN
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }
        public string TV
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }
       public string DT
        {
            get { return label6.Text; }
            set { label6.Text = value; }
        }
    }
}
