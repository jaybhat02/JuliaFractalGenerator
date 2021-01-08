using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal_Julia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global variables(has the fractal been zoomed in already?, c value; cx and cy)
        string GlobalcX = "-0.4";
        string GlobalcY = "-0.59";
        bool zoomedIn = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            JuliaSet(0, 0, 1);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //zooms out and recentres the fractal
            zoomedIn = false;
            JuliaSet(0, 0, 1);
        }

        private void ResetOriginalButton_Click(object sender, EventArgs e)
        {
            //resets julia fractal to the original fractal with c-calue = -0.4 -0.59i
            GlobalcX = "-0.4";
            GlobalcY = "-0.59";
            zoomedIn = false;
            JuliaSet(0, 0, 1);
        }

        private void PictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //when the user double clciks on a given point on the julia fractal, it repositions and zooms into that point
            double xcoord = e.X;
            double ycoord = e.Y;
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            if (!zoomedIn)
            {
                xcoord = (xcoord - (width / 2)) / (width * 1 / 3);
                ycoord = (ycoord - (height / 2)) / (height * 1 / 3);

                zoomedIn = true;

                JuliaSet(xcoord, ycoord, ZoomTrackBar.Value);
            }
        }

        private void EquationButton_Click(object sender, EventArgs e)
        {
            //when user inputs a c-value, it needs to be dissected to obtain cX and cY
            //once the value is dissected, the julia fractal for that given c-value is rendered
            string equation = EquationTextBox.Text.Replace(" ", string.Empty);
            string[] seperatedEquation;
            char[] seperator = { '-', '+', 'i' };
            seperatedEquation = equation.Split(seperator);

            string x = "";
            string y = "";

            if (equation.StartsWith("-"))
            {
                x = "-" + seperatedEquation[1];
                y = seperatedEquation[2];
            }
            else
            {
                x = seperatedEquation[0];
                y = seperatedEquation[1];
            }
            if (string.Equals(equation.Substring(x.Length, 1), "-"))
            {
                y = y.Insert(0, "-");
            }
            GlobalcX = x;
            GlobalcY = y;
            JuliaSet(0, 0, 1);
        }

        private void JuliaSet(double moveX, double moveY, int zoomFactor)
        {
            //Declariation of variables 
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            double cX = Convert.ToDouble(GlobalcX);
            double cY = Convert.ToDouble(GlobalcY);
            double zx, zy, tmp;
            int i;
            var bitmap = new Bitmap(width, height);
            var colors = (from c in Enumerable.Range(0, 256)
                          select Color.FromArgb((c >> 5) * 36, (c >> 3 & 7) * 36, (c & 3) * 85)).ToArray();

            //two for loops for both the x and y coordinates 
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    zx = 1.0 * (x - (width / 2)) / (width * zoomFactor / 3) + moveX;
                    zy = 1.0 * (y - (height / 2)) / (height * zoomFactor / 3) + moveY;

                    i = 255; //max iterations chosen to be 255 to work with RGB colour gamut

                    /*two conditions: 
                     * 1) is the z-value less than 2 
                     * 2) has there been less than 255 iterations
                    */
                    while (Math.Pow(zx, 2) + Math.Pow(zy, 2) < 2 && i > 0)
                    {
                        tmp = Math.Pow(zx, 2) - Math.Pow(zy, 2) + cX; // temp = z + c
                        zy = 2.0 * zx * zy + cY;
                        zx = tmp;
                        i--;
                    }
                    bitmap.SetPixel(x, y, colors[i]); //colour of pixel depended on the number of iterations before the pixel coordinate passed 2
                }
            }

            pictureBox1.Image = bitmap;
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            // When user moves the mouse over the mandelbrot set, a label shows the corresponding C-value

            double xcoord = (1.0 * (e.X - (pictureBox2.Width / 2)) / (pictureBox2.Width / 2) - 0.5);
            double ycoord = (1.0 * (e.Y - (pictureBox2.Height / 2)) / (pictureBox2.Height / 2));
            if (ycoord < 0)
            {
                cValueLabel.Text = "C = " + xcoord.ToString() + ycoord.ToString() + "i ";
            }
            else
            {
                cValueLabel.Text = "C = " + xcoord.ToString() + " + " + ycoord.ToString() + "i ";
            }
        }

        private void PictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //When user double clicks mandelbrot set, the coordinates are obtained and used to remake the julia set
            double xcoord = (1.0 * (e.X - (pictureBox2.Width / 2)) / (pictureBox2.Width / 2) - 0.5);
            double ycoord = (1.0 * (e.Y - (pictureBox2.Height / 2)) / (pictureBox2.Height / 2));
            GlobalcX = xcoord.ToString();
            GlobalcY = ycoord.ToString();
            JuliaSet(0, 0, 1);
        }

        private void Mandelbrot()
        {
            //method that was used to render an image of the mandelbrot set once
            //for efficiency purposes the image was redered once and saved as a png
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            double zx, zy, tmp, cX, cY;
            int i;
            var bitmap = new Bitmap(width, height);
            var colors = (from c in Enumerable.Range(0, 256)
                          select Color.FromArgb((c >> 5) * 36, (c >> 3 & 7) * 36, (c & 3) * 85)).ToArray();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    cX = 1.0 * (x - (width / 2)) / (width * 1 / 2) - 0.5;
                    cY = 1.0 * (y - (height / 2)) / (height * 1 / 2) + 0;
                    zx = 0;
                    zy = 0;

                    i = 255;


                    while (Math.Pow(zx, 2) + Math.Pow(zy, 2) < 2 && i > 0)
                    {
                        tmp = Math.Pow(zx, 2) - Math.Pow(zy, 2) + cX; // temp = z + c
                        zy = 2.0 * zx * zy + cY;
                        zx = tmp;
                        i--;
                    }
                    bitmap.SetPixel(x, y, colors[i]);
                }
            }
            bitmap.Save("mbrot.png");
        }

    }
}
