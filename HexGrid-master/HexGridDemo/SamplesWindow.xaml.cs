using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using HexGridHelpers;

namespace HexGridDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        int[,] array = new int[7, 7];

        private void MenuClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            //MessageBox.Show(button.Content.ToString(), "HexMenu", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            //button.Background = new ImageBrush
            //{
            //    ImageSource = new BitmapImage(new System.Uri("D:\\HexGrid\\HexGrid\\Cat.png"))
            //};

            int row = Grid.GetRow((UIElement)hexForm.SelectedItem);
            int column = Grid.GetColumn((UIElement)hexForm.SelectedItem);
            MessageBox.Show("Row: " + row + ", column: " + column);
        }
    }
}
