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
        StringBuilder errors = new StringBuilder();
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
            int score = 0;
            bool a = (bool)question2.IsChecked && (bool)question6.IsChecked && (bool)question14.IsChecked && (bool)question20.IsChecked && (bool)question23.IsChecked && (bool)question27.IsChecked && (bool)question33.IsChecked && (bool)question37.IsChecked && (bool)question43.IsChecked && (bool)question46.IsChecked;
            if (a == true)
            {
                MessageBox.Show("Тест пройден без ошибок", "Тестирование пройдено", MessageBoxButton.OK, MessageBoxImage.Information);


                MessageBox.Show($"Тестирование завершено.{Environment.NewLine}Правильных ответов: 10 / 10.{Environment.NewLine}Оценка в пятибальной шкале: 5", "Тестирование пройдено", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow window1 = new MainWindow();
                window1.Show();
                this.Close();
                return;
            }
            else
                switch (QuestionsTest.SelectedIndex)
                {
                    case 1:
                        if (question1.IsChecked == true)
                        {
                            score++;
                        }
                        else
                        {
                            errors.AppendLine("1/10 - Укажите текстовый тип данных");
                        }
                        goto case 2;
                    case 2:
                        if (question6.IsChecked == true)
                        {
                            score++;
                        }
                        else
                        {
                            errors.AppendLine("2/10 - Как называется конструктор для хранения интерфейса?");
                        }
                        goto case 3;
                    case 3:
                        if (question14.IsChecked == true)
                        {
                            score++;
                        }
                        else
                        {
                            errors.AppendLine("3/10 - В каком каталоге хранятся все визуальные ресурсы приложения?");
                        }
                        goto case 4;
                    case 4:
                        if (question20.IsChecked == true)
                        {
                            score++;
                        }
                        else
                        {
                            errors.AppendLine("4/10 - Как называется текстовый редактор от компании Microsoft?");
                        }
                        goto case 5;
                    case 5:
                        if (question23.IsChecked == true)
                        {
                            score++;
                        }
                        else
                        {
                            errors.AppendLine("5/10 - Какой из нижеперечисленных вариантов не является правильным именем каталога?");
                        }
                        goto case 6;
                    case 6:
                        if (question27.IsChecked == true)
                        {
                            score++;
                        }
                        else
                        {
                            errors.AppendLine("6/10 - Сколько окон может быть одновременно открыто?");
                        }
                        goto case 7;
                    case 7:
                        if (question33.IsChecked == true)
                        {
                            score++;
                        }
                        else
                        {
                            errors.AppendLine("7/10 - Что такое Юнит-тестирование?");
                        }
                        goto case 8;
                    case 8:
                        if (question37.IsChecked == true)
                        {
                            score++;
                        }
                        else
                        {
                            errors.AppendLine("8/10 - Какой метод тестирования фокусируется на внутренней структуре кода?");
                        }
                        goto case 9;
                    case 9:
                        if (question43.IsChecked == true)
                        {
                            score++;
                        }
                        else
                        {
                            errors.AppendLine("9/10 - Какой метод тестирования направлен на анализ требований и спецификаций без доступа к исходному коду?");
                        }
                        goto case 10;
                    case 10:
                        if (question46.IsChecked == true)
                        {
                            score++;
                        }
                        else
                        {
                            errors.AppendLine("10/10 - Как называется программа для написание кода на всех языках программирования?");
                        }
                        break;
            }
            MessageBox.Show($"Вопросы, на которые были даны неправильные ответы:{Environment.NewLine}{errors}", "Тестирование пройдено", MessageBoxButton.OK, MessageBoxImage.Information);
            MessageBox.Show($"Тестирование завершено.{Environment.NewLine}Правильных ответов: {score}/10.{Environment.NewLine}Оценка в пятибальной шкале: {score / 2}", "Тестирование пройдено", MessageBoxButton.OK, MessageBoxImage.Information);
            MainWindow window2 = new MainWindow();
            window2.Show();
            this.Close();
            return;
        }
    }
}
