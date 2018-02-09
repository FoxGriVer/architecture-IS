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

namespace AIS_Lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel VM;

        public MainWindow()
        {
            InitializeComponent();
            VM = new ViewModel();
            DataContext = VM;
            
            //VM.DownloadData();                       если не нужна кнопка
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(CarsGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < CarsGrid.SelectedItems.Count; i++)
                {
                    Car car = CarsGrid.SelectedItems[i] as Car;
                    if (car != null)
                    {
                        VM.Cars.Remove(car);
                    }
                }
            }
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            string afterSave = VM.SendData();
            VM.MakeConnection(afterSave);
        }

        private void downloadButton_Click(object sender, RoutedEventArgs e)
        {
            VM.DownloadData();
        }
    }
}
