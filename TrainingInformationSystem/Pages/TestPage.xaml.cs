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

namespace TrainingInformationSystem.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        List<string> listAnswer = new List<string>() { "1", "2", "3", "4" };

        private int numberLesson;
        public TestPage(int numLesson)
        {
            numberLesson = numLesson;
            InitializeComponent();
            cmbAnswer.ItemsSource = listAnswer;

            tbTitleLesson.Text = EF.AppData.Context.Lesson.Where(i => i.IDLesson == numLesson + 1).FirstOrDefault().LessonTitle;
            tbQuestion.Text = EF.AppData.Context.TestLesson.Where(i => i.IDLesson == numLesson + 1).FirstOrDefault().Question;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (cmbAnswer.SelectedIndex + 1 == EF.AppData.Context.TestLesson.Where(i => i.IDLesson == numberLesson + 1).FirstOrDefault().NumberCorrectAnswer)
            {
                ClassHelper.UserDataClass.user.Progress += 10;
                MessageBox.Show("Ответ верный", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                EF.AppData.Context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Ответ верный", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
