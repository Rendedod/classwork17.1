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
using System.Windows.Forms;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace classwork17._4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void searhText(object sender, MouseButtonEventArgs e)
        {
            errorSearch.Text = "";
            if (secendaryText.Text != "")
            {
                if (mainText.Text.Contains(secendaryText.Text))
                {
                    mainText.Focus();
                    mainText.SelectionBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    mainText.Select(mainText.Text.IndexOf(secendaryText.Text), secendaryText.Text.Length);
                }
                else
                {
                    errorSearch.Text = "Нет совпадений";
                }
            }
        }

        //Кнопка "Поиск"
        private void enterSearch(object sender, System.Windows.Input.MouseEventArgs e) => search.Background = new SolidColorBrush(Color.FromRgb(80, 80, 80));
        private void liveSearch(object sender, System.Windows.Input.MouseEventArgs e) => search.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
    }
}
