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
        private int roleUser;
        public MainWindow(int role)
        {
            roleUser = role;
            InitializeComponent();

            if (role == 1)
            {
                mainFrame.Navigate(new StartPage());

                tbTitle.Text = String.Empty;
            }
            else
            {
                mainFrame.Navigate(new AccountTeacherPage());
                tbTitle.Text = "Личный кабинет";
            }
           

            ClassHelper.ClassNavigate.frame = mainFrame;
        }

        private void Image_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (roleUser == 1)
            {
                mainFrame.Navigate(new AccountStudentPage());
                tbTitle.Text = "Личный кабинет";
            }
            else
            {
                mainFrame.Navigate(new AccountTeacherPage());
                tbTitle.Text = "Личный кабинет";
            }
            
        }

        private void tbL1_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new LessonPage(1));
        }

        private void tbL2_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new LessonPage(2));
        }

        private void tbL3_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new LessonPage(3));
        }

        private void tbL4_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new LessonPage(4));
        }

        private void tbL5_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new LessonPage(5));
        }

        private void tbL6_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new LessonPage(6));
        }

        private void tbL7_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new LessonPage(7));
        }

        private void tbL8_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new LessonPage(8));
        }
    }
}
