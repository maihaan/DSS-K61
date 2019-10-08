﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void qLMệnhĐềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmMenhDe fmd = new GUI.frmMenhDe();
            fmd.ShowDialog();
        }

        private void qLLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmLuat fl = new GUI.frmLuat();
            fl.ShowDialog();
        }

        private void suyDiễnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.ShowDialog();
        }
    }
}
