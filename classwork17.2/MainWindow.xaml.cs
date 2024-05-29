using System;
using System.Collections.Generic;
using System.Windows;
using System.IO;


namespace classwork17._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> allFonts;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FormLoaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void underlined_Checked(object sender, RoutedEventArgs e)
        {
            if (mainText.TextDecorations == TextDecorations.Underline)
                mainText.TextDecorations = null;
            else
                mainText.TextDecorations = TextDecorations.Underline;
        }

        private void thick_Checked(object sender, RoutedEventArgs e)
        {
            if (mainText.FontWeight == FontWeights.Bold)
                mainText.FontWeight = FontWeights.Thin;
            else
                mainText.FontWeight = FontWeights.Bold;
        }

        private void italics_Checked(object sender, RoutedEventArgs e)
        {
            if (mainText.FontStyle == FontStyles.Italic)
                mainText.FontStyle = FontStyles.Normal;
            else
                mainText.FontStyle = FontStyles.Italic;
        }
    }
}
