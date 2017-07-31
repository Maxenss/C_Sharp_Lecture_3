using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lecture_3
{
    class Program
    {
        // F11 - пошаговое выполнения кода

        static void Main(string[] args)
        {
            #region Теория

            // Циклы. Циклические конструкции. Вложенные циклы.
            // Операторы while, do-while, for. Метки переходов goto.

            // Одно повторения цикла - итерация
            // Примеры циклов : оборот секундной стрелки, оборот минутной стрелки, 
            // оборот колеса, ритм дня и т.д.

            // Цикл while. Цикл с предусловием.
            // Сначала проверяем условие, если условие удовлетворяет истинности,
            // то выполняем итерацию (повтор тела цикла). Если условие, не удовл. 
            // истинности, то завершаем выполнения цикла.

            // Синтаксис цикла while

            // a < 10 - условие
            // ++a - тело цикла
            int a = 0;
            while (a < 10)
            {
                ++a;
            }

            // Цикл do-while. Цикл с постусловием
            // Сначала выполняем тело цикла, потом проверяем условие
            // Если условие удовлетворяет истинности,
            // то выполняем итерацию (повтор тела цикла). Если условие, не удовл. 
            // истинности, то завершаем выполнения цикла.
            // Мы выполняем цикл do-while, как минимум, один раз, 
            // независимо от условия.

            // Синтаксис цикла do-while
            a = 10;
            do
            {
                ++a;
            } while (a < 10);
            Console.WriteLine("a = {0}", a); // 11 

            // Цикл for. Цикл со счетчиком
            // Цикл for, по своей сути, представляет собой, цикл while, но 
            // с разницей в том, что в цикле for есть встроенный механизм 
            // для создания счетчика цикла, и изменения его шага

            // Синтаксис цикла for

            // int 0 = 0 - блок инициализация счетчика
            // o < 10 - условие цикла (как в цикле while)
            // o++ - шаг изменения счетчика (блок инкрементации)

            for (int o = 0; o < 10; o++)
            {
                // тело цикла
            }

            #endregion

            #region Практика
            // Для запуска примера, уберите комментарии

            //Example1();
            //Example2();
            //Example3();
            //Example4();
            //Example5();
            //Example6();

            #endregion 

            // Задержка выполнения
            Console.ReadKey();
        }

        static void Example1()
        {
            int a = 12345679;
            int num = 9;

            while (num <= 81)
            {
                Console.WriteLine("{0} * {1} = {2}", a, num, a * num);
                num += 9;
            }
        }

        static void Example2()
        {
            Console.WriteLine("Задание 2");
            int num = 2;

            while (num <= 20)
            {
                Console.WriteLine("sin{0} = {1}", num, Math.Sin(num));
                ++num;
            }
        }

        static void Example3()
        {
            Console.WriteLine("Задание 3");

            double x = 0;
            double sum = 0;
            double element = 0;
            int i = 1;
            int sign = 1;
            int factorial = 1;

            Console.Write("Введите x : ");
            x = Convert.ToDouble(Console.ReadLine());

            while (i <= 13)
            {
                // Обнуляем переменную факториала
                factorial = 1;
                // Считаем факториал
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }

                // Math.Pow - возведение в степень 
                element = Math.Pow(x, i) / factorial;

                sum = sum + sign * element;

                sign = sign * -1;
                i += 2;
            }
            Console.WriteLine("Сумма первых 7 членов ряда = {0}", sum);
        }

        static void Example4()
        {
            double y = 0;
            double a = 0;
            double b = 0;
            double h = 0;

            Console.Write("Введите a : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b : ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите h : ");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Задание 4.1");

            while (a <= b)
            {
                y = Math.Tan(a);

                Console.WriteLine("x = {0}, y = {1}", a, y);

                a += h;
            }

            Console.WriteLine("Задание 4.2");

            Console.Write("Введите a : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b : ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите h : ");
            h = Convert.ToDouble(Console.ReadLine());

            while (a <= b)
            {
                y = (1 / Math.Tan(a)) + 1;

                Console.WriteLine("x = {0}, y = {1}", a, y);

                a += h;
            }

        }

        static void Example5()
        {
            #region Посчитать сумму первых 20 членов арифм. прогрессии,
            // где шаг прогрессии равен 3. Нулевой член прогрессии = 0

            int sum = 0;
            int element = 0;
            int step = 3;
            int i = 0;

            while (i < 20)
            {
                element = element + step;
                sum += element;
                ++i;
            }

            Console.WriteLine("Сумма первых 20 членов арифм. прогрессии равна = {0}", sum);
            #endregion
        }

        static void Example6()
        {
            #region Вывод таблицы умножения на 9
            int number = 9;
            int num2 = 1;

            while (num2 <= 10)
            {
                Console.WriteLine("{0} * {1} = {2}", number, num2, (number * num2));
                ++num2;
            }
            #endregion
        }

        static void Example7()
        {
            int factorial = 1;
            int i = 1; // 1...4
            //factorial =  // !4 // 1 * 2 * 3 * 4

            // Где, Enter - метка перехода
            Enter: if (i < 4)
            {
                ++i;
                factorial = factorial * i;
                // Переход по метке Enter
                goto Enter;
            }

            int factorial2 = 1;
            int i2 = 1;

            while (i2 < 4)
            {
                ++i2;
                factorial2 = factorial2 * i2;
            }

            Console.WriteLine("Факториал !4 = {0}", factorial);
            Console.WriteLine("Факториал !4 = {0}", factorial2);
        }
    }
}
