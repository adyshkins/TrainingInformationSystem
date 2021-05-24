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
using TrainingInformationSystem.Windows;
using TrainingInformationSystem.EF;
using TrainingInformationSystem.ClassHelper;

namespace TrainingInformationSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
      
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var userAuth = EF.AppData.Context.User.ToList().
                Where(i => i.Login == txtLogin.Text && i.Password == txtPassword.Text).
                FirstOrDefault();

            if (userAuth != null)
            {
                if (userAuth.IDRole == 1)
                {
                    UserDataClass.user = userAuth;

                    MainWindow mainWindow = new MainWindow(1);
                    mainWindow.Show();
                    Close();
                }
                else if (userAuth.IDRole == 2)
                {
                    MainWindow mainWindow = new MainWindow(2);
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MainWindow mainWindow = new MainWindow(3);
                    mainWindow.Show();
                    Close();
                }
            }

            else
            {
                MessageBox.Show("Пользователя с такими данными не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
