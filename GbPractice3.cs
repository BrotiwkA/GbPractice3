using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexAndSumOfData // Задание 1 - Варианты а и б
{
    internal class CComplex // Класс для представления комплексного числа
    {
        private double im;
        double re;

   
        public CComplex()  // Конструктор без параметров
        {
            im = 0;
            re = 0;
        }
        public CComplex(double _im, double re) // Конструктор с параметрами
        {
            im = _im;
            this.re = re;
        }
        public CComplex Plus(CComplex x2) //Метод сложения с другим комплексным числом
        {
            CComplex x3 = new CComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public CComplex Minus(CComplex x2) // Метод разности с другим комплексным числом
        {
            CComplex x3 = new CComplex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        public CComplex Multi(CComplex x2) // Метод произведения с другим комплексным числом
        {
            CComplex x3 = new CComplex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }
        public double Im // Свойство для мнимой части
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }
        public string ToString() // Метод представления комплексного числа в удобной форме
        {
            return re + "+" + im + "i";
        }

        static int GetInt() // Задание 2
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                else return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа подсчета нечетных положительных чисел");
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            int AmountOfOddNumbers = 0;
            while (true)
            {
                int number = GetInt();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    AmountOfOddNumbers++;
                }
            }

            Console.WriteLine(Environment.NewLine + "Количество чисел: " + AmountOfOddNumbers);

            Console.ReadKey();
        }
    }
}
