﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        private int x1, y1, x2, y2;
        private double a, t, fi;
        private Pen pen = new Pen(Color.DarkGreen,3);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            a = 150;
            fi = -0.5;
            t = Math.Tan(fi);
            x2 = x1 + (int)((2 * a * t) / (1 + t * t * t));
            y2 = y1 - (int)((2 * a * t) / (1 + t * t * t));

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            fi += 0.01;
            t=Math.Tan(fi);
            x2 = x1 + (int)((2 * a * t) / (1 + t * t * t));
            y2 = y1 - (int)((2 * a * t) / (1 + t * t * t));
            timer1.Start();
            Invalidate();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(pen, x2, y2, 20, 20);

        }
    }
}