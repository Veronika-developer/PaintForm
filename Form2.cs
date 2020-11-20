using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form2 : Form
    {
        int R, G, B;
        public Form2()
        {
            InitializeComponent();

            RedScrollBar1.Tag = REDnumericUpDown1;
            GreenhScrollBar3.Tag = GREENnumericUpDown2;
            BluehScrollBar2.Tag = BLUEnumericUpDown3;

            REDnumericUpDown1.Tag = RedScrollBar1;
            GREENnumericUpDown2.Tag = GreenhScrollBar3;
            BLUEnumericUpDown3.Tag = BluehScrollBar2;
        }

        private void RedScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            REDnumericUpDown1.Value = e.NewValue;
            R = RedScrollBar1.Value;
            ColorPictureBox();
        }

        private void GreenhScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            GREENnumericUpDown2.Value = e.NewValue;
            G = GreenhScrollBar3.Value;
            ColorPictureBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.currentPen.Color = Color.FromArgb(R, G, B);
            Form1.historyColor = Color.FromArgb(R, G, B);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                RedScrollBar1.Value = colorDialog.Color.R;
                GreenhScrollBar3.Value = colorDialog.Color.G;
                BluehScrollBar2.Value = colorDialog.Color.B;

                REDnumericUpDown1.Value = colorDialog.Color.R;
                GREENnumericUpDown2.Value = colorDialog.Color.G;
                BLUEnumericUpDown3.Value = colorDialog.Color.B;

                R = colorDialog.Color.R;
                G = colorDialog.Color.G;
                B = colorDialog.Color.B;

                ColorPictureBox();
            }
            Form1 Main = Owner as Form1;
        }

        private void REDnumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            R = (int)numericUpDown.Value;
            ColorPictureBox();
        }

        private void GREENnumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            G = (int)numericUpDown.Value;
            ColorPictureBox();
        }

        private void BLUEnumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            B = (int)numericUpDown.Value;
            ColorPictureBox();
        }

        private void BluehScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            BLUEnumericUpDown3.Value = e.NewValue;
            B = BluehScrollBar2.Value;
            ColorPictureBox();
        }

        private void ColorPictureBox()
        {
            ColorpictureBox1.BackColor = Color.FromArgb(R, G, B);
        }
    }
}
