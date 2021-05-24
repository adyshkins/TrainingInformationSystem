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
    /// Логика взаимодействия для LessonPage.xaml
    /// </summary>
    public partial class LessonPage : Page
    {
        private int numberLesson;
        public LessonPage()
        {
            InitializeComponent();
        }
        public LessonPage(int numLesson)
        {
            InitializeComponent();
            numberLesson = numLesson;
            tbTitleLesson.Text = EF.AppData.Context.Lesson.Where(i => i.IDLesson == numLesson + 1).FirstOrDefault().LessonTitle;
            tbTextLesson.Text = EF.AppData.Context.Lesson.Where(i => i.IDLesson == numLesson + 1).FirstOrDefault().LessonContent;

        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.ClassNavigate.frame.Navigate(new TestPage(numberLesson));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
