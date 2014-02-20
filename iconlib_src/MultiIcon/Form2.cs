using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiIconTester
{
    public partial class Form2 : Form
    {
        #region Constructors
        public Form2()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
        #endregion
    }
}