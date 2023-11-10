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

namespace WPF_StasIvan_PR7
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

        private void ExitWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
        }

        private void NextQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionsTest.SelectedIndex < Test1.TabIndex)
                QuestionsTest.SelectedIndex++;
            if (QuestionsTest.SelectedIndex == 9)
            {
                EndWindow.Visibility = Visibility.Visible;
            }
            if (QuestionsTest.SelectedIndex >= 1)
            {
                BackWindow.Visibility = Visibility.Visible;
            }
        }

        private void BackWindow_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionsTest.SelectedIndex < Test1.TabIndex)
                QuestionsTest.SelectedIndex--;
            if (QuestionsTest.SelectedIndex < 0)
            {
                MessageBox.Show("Вернуться на нулевой вопрос нельзя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                QuestionsTest.SelectedIndex++;
                return;
            }
            if (QuestionsTest.SelectedIndex < 9)
            {
                EndWindow.Visibility = Visibility.Hidden;
            }
            if (QuestionsTest.SelectedIndex == 0)
            {
                BackWindow.Visibility = Visibility.Hidden;
            }
        }

        private void EndWindow_Click(object sender, RoutedEventArgs e)
        {
            //WindowResult window2 = new WindowResult();
            //window2.Show();
            //if ()
            //MessageBox.Show($"Список вопросов на которые были даны неправильные ответы:{Environment.NewLine}" + (if (QuestionsTest.SelectedIndex < 9));
        }
    }
}
