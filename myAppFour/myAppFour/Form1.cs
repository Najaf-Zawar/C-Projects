using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myAppFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean shouldPaint = false;
        String InpStr;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Blue), e.X, e.Y, 4, 4);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel_mouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void panel_mouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    if (rbRed.Checked)
                    {
                        graphics.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 4, 4);
                    }
                }
            }
        }
        int val = 0;
        private void txtInpString_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
