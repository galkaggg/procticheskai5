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

namespace procticheskai5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btRez_Click(object sender, RoutedEventArgs e)
        {
            Pair First = new Pair();//Создаем объекты классов 
            Pair Second = new Pair();
            bool boolFirstPairOneNumber = int.TryParse(tbFirstPairOneNumber.Text, out int firstPairOneNumber);//Создаем переменную boolOneNumber и метод TryParse пытается преоброзовать текст в число
                                                                                                              //и если это удается, то переменная boolOneNumber принимает значение true. oneNumber это выходной параметр
            bool boolFirstPairTwoNumber = int.TryParse(tbFirstPairTwoNumber.Text, out int firstPairTwoNumber);//Создаем переменную boolTwoNumber и метод TryParse пытается преоброзовать текст в число
                                                                                                              //и если это удается, то переменная boolTwoNumber принимает значение true. twoNumber это выходной параметр
            bool boolSecondPairOneNumber = int.TryParse(tbSecondPairOneNumber.Text, out int secondPairOneNumber);//то же самое только с другими переменнами
            bool boolSecondPairTwoNumber = int.TryParse(tbSecondPairTwoNumber.Text, out int secondPairTwoNumber);

            if (boolFirstPairOneNumber == true && boolFirstPairTwoNumber == true && boolSecondPairOneNumber == true && boolSecondPairTwoNumber == true)//Здесь мы проверяем переменные bool на true
            {
                First.SetParams(firstPairOneNumber, firstPairTwoNumber);// отдаем первую пару чисел SetParams
                Second.SetParams(secondPairOneNumber, secondPairTwoNumber);// тоже самое только для второй пары
                bool boolCalculater = First.Compare(First, Second);// забираем переменную bool 
                if (boolCalculater == true) MessageBox.Show("пара P1 > P2");//Если true то одно действе, если false то другое
                else MessageBox.Show("пара P1 < P2");
            }
            else if ((boolFirstPairOneNumber == true || boolFirstPairTwoNumber == true) && (boolSecondPairOneNumber == true || boolSecondPairTwoNumber == true))
            {
                First.SetParams(firstPairOneNumber);// отдаем первую пару чисел SetParams
                Second.SetParams(secondPairTwoNumber);//тоже самое только для второй пары
                bool boolCalculater = First.Compare(First, Second);// мы забираем переменную bool 
                if (boolCalculater == true) MessageBox.Show("пара P1 > P2");//Если true то одно действе, если false то другое
                else MessageBox.Show("пара P1 < P2");
            }
            else MessageBox.Show("Введите Нормальные числа!!!!!!");
        }

        private void Info_Click(object sender, RoutedEventArgs e)//Информация
        {
            MessageBox.Show("Сделала:Галкина Ирина ИСП-34\nЗадание:Создать класс Pair (пара чисел). Создать необходимые методы и свойства.  \r\nОпределить метод сравнения пар: пара p1 больше пары р2, если (first.pl > first.р2) \r\nили (first.pl = first.р2) и (second.pl > second.р2). Создать перегруженные методы \r\nSetParams, для установки параметров объекта.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)//Выход
        {
            Close();
        }
    }
}