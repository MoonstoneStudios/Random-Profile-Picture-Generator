using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProfile
{
    public partial class Form1 : Form
    {
        private Color colorOne = Color.White;
        private Color colorTwo;

        public Form1()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(GenerateIcon().GetHicon());
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (useCustom.Checked)
            {
                colorOne = color1.BackColor;
                colorTwo = color2.BackColor;
            }

            Generate();

        }

        private Bitmap GenerateIcon()
        {

            Bitmap finalImage = new Bitmap(100, 100);

            if (!useCustom.Checked)
            {
                colorTwo = GenerateRandomColor();
                colorOne = twoRand.Checked ? GenerateRandomColor() : Color.White;
            }

            using (Graphics g = Graphics.FromImage(finalImage))
            {
                int x = 0;
                int y = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (x >= 100)
                        {
                            x = 0;
                            y += 20;
                        }
                        Rectangle rect = new Rectangle(x, y, 20, 20);
                        Color random = RandomBool() ? colorOne : colorTwo;
                        Pen pen = new Pen(random);
                        g.FillRectangle(pen.Brush, rect);
                        x += 20;
                    }
                }
                Pen pen1 = new Pen(Color.Black, 10);
                g.DrawLine(pen1, 0, 0, 0, 100);
                g.DrawLine(pen1, 0, 0, 100, 0);
                g.DrawLine(pen1, 0, 100, 100, 100);
                g.DrawLine(pen1, 100, 100, 100, 0);
            }

            return finalImage;

        }

        private void Generate()
        {

            Bitmap finalImage = new Bitmap(500, 500);

            if (!useCustom.Checked)
            {
                colorTwo = GenerateRandomColor();
                colorOne = twoRand.Checked ? GenerateRandomColor() : Color.White;
            }

            using (Graphics g = Graphics.FromImage(finalImage))
            {
                int x = 0;
                int y = 0;
                for(int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (x >= 500)
                        {
                            x = 0;
                            y += 100;
                        }
                        Rectangle rect = new Rectangle(x, y, 100, 100);
                        Color random = RandomBool() ? colorOne : colorTwo;
                        Pen pen = new Pen(random);
                        g.FillRectangle(pen.Brush, rect);
                        x += 100;
                    }
                }
            }

            //finalImage.Save($"{Environment.SpecialFolder.ApplicationData}\\RandomProfileTemp\\temp.png");
            display.Image = finalImage;

        }
        
        Random rand = new Random();

        private Color GenerateRandomColor()
        {
            int r = rand.Next(0, 255);
            int g = rand.Next(0, 255);
            int b = rand.Next(0, 255);
            Color color = Color.FromArgb(r, g, b);
            return color;
        }


        private bool RandomBool()
        {
            int r = rand.Next(0, 200);
            return r > 100;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (display.Image == null) return;
            Image image = display.Image;
            saveFileDialog1.Filter = "Images (*.PNG)|*.PNG";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image.Save($"{saveFileDialog1.FileName}", ImageFormat.Png);
            }
        }

        private void color1_Click(object sender, EventArgs e)
        {
            colorDialog1.AnyColor = true;
            colorDialog1.AllowFullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color1.BackColor = colorDialog1.Color;
            }
        }

        private void color2_Click(object sender, EventArgs e)
        {
            colorDialog1.AnyColor = true;
            colorDialog1.AllowFullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color2.BackColor = colorDialog1.Color;
            }
        }
    }
}
