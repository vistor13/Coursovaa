﻿using System;
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
    public partial class WrongName : Form
    {
        public WrongName()
        {
            InitializeComponent();
        }
        public string TN
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}
