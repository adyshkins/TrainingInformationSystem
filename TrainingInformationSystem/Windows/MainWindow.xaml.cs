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
using System.Windows.Shapes;
using TrainingInformationSystem.Pages;

namespace TrainingInformationSystem.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new StartPage());

            ClassHelper.ClassNavigate.frame = mainFrame;
        }

        private void TextBlock_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new LessonPage());
        }

        private void Image_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new AccountTeacherPage());
        }
    }
}
