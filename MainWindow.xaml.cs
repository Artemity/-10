using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace практика_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> list = new List<int>();//возвращает новый список
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программу подготовил студент группы ИСП-31 Лотаков Артемий\nПрактическая 10 Вариант 13\nДан массив в диапазоне [-100;100] найти количество четных и нечетных", "О программе");
        }

        private void btnAddElement_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(addValue.Text, out int value) && value >= -100 && value <= 100)
            {
                list.Add(value);
                listBox.Items.Add(value);
            }
            else MessageBox.Show("Введены неверные данные");
            addValue.Clear();
            outEven.Clear();
            outOdd.Clear();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int counterEven = 0;
            int counterOdd = 0;
            if (listBox.Items.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        counterEven++;
                    }
                    if (list[i] % 2 != 0)
                    {
                        counterOdd++;
                    }
                }
                outEven.Text = counterEven.ToString();
                outOdd.Text = counterOdd.ToString();
            }
            else MessageBox.Show("Введите значения в таблицу");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            listBox.Items.Clear();
            addValue.Clear();
            outEven.Clear();
            outOdd.Clear();
        }
    }
}