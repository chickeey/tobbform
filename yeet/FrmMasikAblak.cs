﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeet
{
    public partial class FrmMasikAblak : Form
    {
        FrmMain FrmMainRef;
        public FrmMasikAblak(string szoveg, FrmMain foablak)
        {
            InitializeComponent();
            FrmMainRef = foablak;
            lbl2.Text = szoveg;

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            FrmMainRef.BackColor = colorDialog1.Color;
        }

        private void FrmMasikAblak_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMainRef.vanMarAblak = false;
        }
    }
}
