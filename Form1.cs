using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        Image imgOriginal;
        bool draw;
        int historyCounter = 0; //счетчик истории

        GraphicsPath currentPath;
        Point oldLocation;
        public static Pen currentPen;
        public static Color historyColor = Color.Black;//сохранение текущего цвета перед использованием ластика
        List<Image> History;//список для истории
        int X = 0;
        int Y = 0;
        int X0 = 0;
        int Y0 = 0;
        int figuri = 0;
        public Form1()
        {
            InitializeComponent();

            draw = false; //переменная, отвественная за рисование
            currentPen = new Pen(Color.Black);// Инициализация пера с чёрным цветом
            currentPen.Width = RazmerKisti.Value;
            History = new List<Image>();//инциализация списка для истории
            History.Add(new Bitmap(706, 410));
        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);

                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();

            }
            else
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                Rectangle pathRect = new Rectangle(X, Y, X0, Y0);
                currentPath.AddRectangle(pathRect);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();

            }
            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter + 1 < 10) historyCounter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);
            draw = false;
            try
            {
                currentPath.Dispose();
            }
            catch { };
            imgOriginal = picDrawingSurface.Image;
        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            LBLxy.Text = "x= " + e.X.ToString() + ", y= " + e.Y.ToString();
            if (draw)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);

                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }
            else
            {
                X = oldLocation.X;
                Y = oldLocation.Y;
                X0 = e.Location.X - oldLocation.X;
                Y0 = e.Location.Y - oldLocation.Y;
            }
        }

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                draw = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
                currentPen.Color = historyColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                draw = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
                currentPen.DashStyle = DashStyle.Solid;
                currentPen.Color = Color.White;
            }
        }

        private void NEWtoolStripButton6_Click(object sender, EventArgs e)
        {

            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Передупреждение", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: SAVEtoolStripButton_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
                Bitmap pic = new Bitmap(706, 410);
                picDrawingSurface.Image = pic;
            }
            else
            {
                Bitmap pic = new Bitmap(706, 410);
                picDrawingSurface.Image = pic;
            }
        }

        private void SAVEtoolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;


            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();

                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
            Graphics g = Graphics.FromImage(picDrawingSurface.Image);
            g.Clear(Color.White);
            g.DrawImage(picDrawingSurface.Image, 0, 0, 750, 500);
        }

        private void OPENtoolStripButton8_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1;

            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);

            picDrawingSurface.AutoSize = true;
        }

        private void EXITtoolStripButton10_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null) { 
                var result = MessageBox.Show("Вы точно хотите выйти?", "Передупреждение", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.No: return;
                case DialogResult.Yes: this.Close(); break;
                case DialogResult.Cancel: return;
            }
            }
            else
            {
                this.Close();
            }
        }

        private void RazmerKisti_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = RazmerKisti.Value;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NEWtoolStripButton6_Click(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPENtoolStripButton8_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SAVEtoolStripButton_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXITtoolStripButton10_Click(sender, e);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void renoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;

            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;

            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void dashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;

            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = true;
        }

        private Image Zoom(Image img, int size)
        {
            Bitmap pic = new Bitmap(img, img.Width + (img.Width * size / 10), img.Height + (img.Height * size / 10));
            Graphics g = Graphics.FromImage(pic);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return pic;
        }

        private void Lupa_Scroll(object sender, EventArgs e)
        {
            picDrawingSurface.Image = Zoom(imgOriginal, Lupa.Value);
        }

        private void COLORtoolStripButton9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COLORtoolStripButton9_Click(sender,e);
        }

        private void picDrawingSurface_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(picDrawingSurface.Image);
            if (e.Button == MouseButtons.Left)
            {
                g.Clear(historyColor);
                History.Add(new Bitmap(picDrawingSurface.Image));
            }
            if (e.Button == MouseButtons.Right)
            {
                g.Clear(Color.White);
                History.Add(new Bitmap(picDrawingSurface.Image));
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель: Вероника Ефимова TARpv19","Информация о разработчике");
        }
    }
}
