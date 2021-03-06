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
using TrainingInformationSystem.ClassHelper;

namespace TrainingInformationSystem.Pages
{
    /// <summary>
    /// Логика взаимодействия для AccountStudentPage.xaml
    /// </summary>
    public partial class AccountStudentPage : Page
    {
        public AccountStudentPage()
        {
            InitializeComponent();

            tblastName.Text = UserDataClass.user.LastName;
            tbFirstName.Text = UserDataClass.user.FirstName;
            tbMiddleName.Text = UserDataClass.user.Patronimic;
            tbLogin.Text = UserDataClass.user.Login;
            tbGroup.Text = UserDataClass.user.Group.NumberGroup;
            prbProgress.Value = Convert.ToDouble(UserDataClass.user.Progress);
        }
    }
}
