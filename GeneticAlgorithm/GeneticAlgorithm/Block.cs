using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    class Block
    {
        Color[,] colors = new Color[64, 64];

        public Block()
        {
            int width = 64, height = 64;
            Random random = new Random();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int a = random.Next(256);
                    int r = random.Next(256);
                    int g = random.Next(256);
                    int b = random.Next(256);
                    this.colors[x, y] = Color.FromArgb(a, r, g, b);
                }
            }
        }

        public void SetImage(PictureBox image)
        {
            int width = 64, height = 64;
            Bitmap bitmap = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    bitmap.SetPixel(x, y, colors[x, y]);
                }
            }
            image.Image = bitmap;
        }

        public void CheckImage(PictureBox image)
        {
            int width = 64, height = 64;
            double similarity = 1.0D;
            Bitmap bitmap = (Bitmap)image.Image;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    int a = 255 - Math.Abs(color.A - colors[x, y].A);
                    int r = 255 - Math.Abs(color.R - colors[x, y].R);
                    int g = 255 - Math.Abs(color.G - colors[x, y].G);
                    int b = 255 - Math.Abs(color.B - colors[x, y].B);
                    double temp = ((double)(a * r * g * b) / Math.Pow(255, 4));
                    similarity *= temp;
                }
            }
            similarity = similarity / 4096;
        }
    }
}
