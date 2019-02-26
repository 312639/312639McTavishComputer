/*Cameron Heinz
 * Feb26
 * Computer design for McTavishs Computer
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _312639McTavishComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> ImageList = new List<string>();
        List<string> PartsList = new List<string>();
        BitmapImage BitImage = new BitmapImage();
        public MainWindow()
        {
            InitializeComponent();
            System.IO.StreamReader streamReader = new System.IO.StreamReader("Parts.txt");

            while (!streamReader.EndOfStream)
            {
                PartsList.Add(streamReader.ReadLine());
            }

            ImageList.Add("https://images-na.ssl-images-amazon.com/images/I/41EDFtP5hpL.jpg"); //CPU 0
            ImageList.Add("http://ecx.images-amazon.com/images/I/4115SLYxXmL.jpg"); //CPUCooler 1
            ImageList.Add("https://cdn.pcpartpicker.com/static/forever/images/product/236276eba14eb68ff5ebce76796bbdac.1600.jpg"); //motherboard 2
            ImageList.Add("https://cdn.pcpartpicker.com/static/forever/images/product/f2da2b3cd490a78e0d3c72634fcd66ca.1600.jpg"); //RAM 3
            ImageList.Add("https://cdn.pcpartpicker.com/static/forever/images/product/5d75e5e4274a02ca8924d7c4d2a575b2.1600.jpg"); //M.2 SSD 4
            ImageList.Add("http://ecx.images-amazon.com/images/I/41H888-QJdL.jpg"); //HDD 5
            ImageList.Add("https://cdn.pcpartpicker.com/static/forever/images/product/d221f95542061503b6872a5a08fd4fe4.1600.jpg"); //Video Card 6
            ImageList.Add("https://cdn.pcpartpicker.com/static/forever/images/product/741521c7460be8cee5b7c4ba6cedf515.1600.jpg"); //Case 7
            ImageList.Add("https://images-na.ssl-images-amazon.com/images/I/51gWr9dnNlL.jpg"); //Power Supply 8
            ImageList.Add("http://ecx.images-amazon.com/images/I/41xKxuZmnML.jpg"); //Optical Drive 9
            ImageList.Add("http://ecx.images-amazon.com/images/I/41t6kzhQbwL.jpg"); //Wirless Adapter 10
            ImageList.Add("https://images-eu.ssl-images-amazon.com/images/I/51siYvAvPPL.jpg"); //HDMI Converter 11
        }

        private void BtnCPU_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage (new Uri(ImageList[0]));
            image.Source = BitImage;
            
            info.Content = PartsList[0] + "\r\n" + PartsList[1] + "\r\n" + PartsList[2] + "\r\n" + PartsList[3] + "\r\n" + PartsList[4];

        }

        private void BtnCPUCooler_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[1]));
            image.Source = BitImage;

            info.Content = PartsList[5] + "\r\n" + PartsList[6] + "\r\n" + PartsList[7] + "\r\n" + PartsList[8];


        }

        private void BtnMotherboad_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[2]));
            image.Source = BitImage;
            info.Content = PartsList[9] + "\r\n" + PartsList[10] + "\r\n" + PartsList[11] + "\r\n" + PartsList[12];
        }

        private void BtnRAM_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[3]));
            image.Source = BitImage;

            info.Content = PartsList[13] + "\r\n" + PartsList[14] + "\r\n" + PartsList[15] + "\r\n" + PartsList[16] + "\r\n" + PartsList[17];
        }

        private void BtnStorageSSD_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[4]));
            image.Source = BitImage;

            info.Content = PartsList[18] + "\r\n" + PartsList[19] + "\r\n" + PartsList[20];
        }

        private void BtnStorageHDD_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[5]));
            image.Source = BitImage;

            info.Content = PartsList[21] + "\r\n" + PartsList[22] + "\r\n" + PartsList[23];
        }

        private void BtnGraphicsCard_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[6]));
            image.Source = BitImage;

            info.Content = PartsList[24] + "\r\n" + PartsList[25] + "\r\n" + PartsList[26] + "\r\n" + PartsList[27];
        }

        private void BtnCase_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[7]));
            image.Source = BitImage;

            info.Content = PartsList[28] + "\r\n" + PartsList[29] + "\r\n" + PartsList[30];
        }

        private void BtnPowerSupply_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[8]));
            image.Source = BitImage;

            info.Content = PartsList[31] + "\r\n" + PartsList[32] + "\r\n" + PartsList[33];
        }

        private void BtnOpticalDrive_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[9]));
            image.Source = BitImage;

            info.Content = PartsList[34] + "\r\n" + PartsList[35] + "\r\n" + PartsList[36];
        }

        private void BtnWirlessAdaptor_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[10]));
            image.Source = BitImage;

            info.Content = PartsList[37] + "\r\n" + PartsList[38] + "\r\n" + PartsList[39];
        }

        private void BtnConverter_Click(object sender, RoutedEventArgs e)
        {
            BitImage = new BitmapImage(new Uri(ImageList[11]));
            image.Source = BitImage;

            info.Content = PartsList[40] + "\r\n" + PartsList[41] + "\r\n" + PartsList[42];
        }

      
    }
}
