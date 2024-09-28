using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Example4
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

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            // Ставим курсор ожидания.
            this.Cursor = Cursors.Wait;

            // Делаем задержку, для создания эффекта, что программа задумалась.
            Thread.Sleep(1000);

            // Берем случайный ответ.
            txtAnswer.Text = AnswerGenerator.GetRandomAnswer();

            // Восстонавиваем прежнее состояние курсора.
            Cursor = null;
        }
    }
}
