using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class GeneticAlgorithm : Form
    {
        public GeneticAlgorithm()
        {
            InitializeComponent();
        }

        private void GeneticAlgorithm_Load(object sender, EventArgs e)
        {
            Block block_0_0 = new Block();
            block_0_0.SetImage(Image_0_0);
            block_0_0.CheckImage(BasedImage);

            //bitmap = (Bitmap)BasedImage.Image;
            //Bitmap bitmap2 = new Bitmap(width, height);
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        Color color =  bitmap.GetPixel(x, y);
            //        bitmap.SetPixel(x, y, color);
            //    }
            //}
            //Image_1_0.Image = bitmap;
        }
    }
}
