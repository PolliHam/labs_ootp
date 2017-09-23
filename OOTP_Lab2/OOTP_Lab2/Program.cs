using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определите переменные всех возможных примитивных типов С#  и проинициализируйте их.   
            short i16 = -32;
            int i32 = 1234;
            long i64 = -44355;

            ushort ui16 = 67;
            uint ui32 = 3484;
            ulong ui64 = 478359;

            byte b8 = 200;
            sbyte sb8 = -120;

            bool bolean8 = false;
            float f32 = 89.45f;
            double d64 = 453.654;
            decimal d128 = 483.343M;

            char ch16 = 'R';
            string str = "Bazinga!";

            // Выполните 5 операций явного и 5 неявного приведения
            decimal d = i64;  // long-> decimal
            int i = i16;      // short-> int
            double n = f32;   // float-> double
            short s = b8;     // byte-> short 
            float f = sb8;    // sbyte-> float

            int u = (int)d128;   // decimal-> int
            byte g = (byte)ui32; // uint-> byte
            long l = (long)d64;  // double -> long
            ushort t = (ushort)i32; // int->short
            sbyte p = (sbyte)f32; // float-> sbyte

            //Выполните упаковку и распаковку значимых типов.
            object o = i32;
            int oi32 = (int)o;

            object e = f32;
            int ei = (int)(float)e;

            //Продемонстрируйте работу с неявно типизированной переменной. 
            var intVar = 465;
            var floatVar = 56.435f;
            var strVar = "ABCD";
            var boolVar = true;
            System.Console.WriteLine("Тип неявно типизированной переменной:\nintVar-{0}",intVar.GetType());
            System.Console.WriteLine("floatVar-{0}\nstrVar-{1}\nboolVar-{2}", floatVar.GetType(), strVar.GetType(), boolVar.GetType());

            //Продемонстрируйте пример работы с Nullable переменной

            float ? nullableVar1 = null;
            float? nullableVar2 = 7849.6f;

            float? x = nullableVar1 ?? nullableVar2; // 7849.6
            System.Console.WriteLine("Результат операции ?? (null - объединение):{0}", x);

            //Объявите строковые литералы. Сравните их. 

            char[] ch = { 'a', 'k', 'u', 't', 'e' };
            string zap = new string('*', 30);
            string strch = new string(ch);
            string strs = "AKUTE";
            if (strs == strch)
            {
                System.Console.WriteLine("Строки strs и strch равны");
            }
            else
            {
                System.Console.WriteLine("Строки strs и strch не равны");
            }
            System.Console.WriteLine("Сравнение этих же строк c помощью Compare: {0}", String.Compare(strch, strs));
            System.Console.WriteLine("Сравнение этих же строк c помощью CompareOrdinal: {0}", String.CompareOrdinal(strch, strs));
            System.Console.WriteLine("Сравнение этих же строк c помощью CompareTo: {0}", strch.CompareTo(strs));

            //Создайте три строки на основе String. Выполните: сцепление, копирование, 
            //выделение подстроки, разделение строки на слова, вставки подстроки в заданную 
            //позицию, удаление заданной подстроки. 

            string str1 = "Фэнни";
            string str2 = "Флэгг";
            string str3 = "Стоя под радугой";
            System.Console.WriteLine("Сцепление строк: {0} ", String.Concat(String.Concat(str1, str2), str3));
            string strCopy = String.Copy(str3);
            System.Console.WriteLine("Копирование строк: {0}", strCopy);
            System.Console.WriteLine("Выделение подстроки: {0}", str3.Substring(6, 3));
            System.Console.WriteLine("Разделение строки на слова");
            char[] separator = ".,;:!?\n\xD\xA\" ".ToCharArray();
            string[] strSplit = str3.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in strSplit)
            { System.Console.WriteLine(word); }
            System.Console.WriteLine("Bставки подстроки в заданную позицию: {0}", str1.Insert(5, "Автор"));
            System.Console.WriteLine("Удаление заданной подстроки: {0}", str3.Remove(4, 5));

            // Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками 

            string emptyString = "";
            string nullString = null;

            bool b = (emptyString == nullString);
            System.Console.WriteLine("Сравнение пустой и null строки: {0}", b);
            System.Console.WriteLine("Длина пустой строки: {0}", emptyString.Length);
            // System.Console.WriteLine("Длина нулевой строки: {0}", nullString.Length);  // NullReferenceException

            //Создайте строку на основе StringBuilder. 
            //Удалите определенные позиции и добавьте новые символы в начало и конец строки. 

            StringBuilder strBild = new StringBuilder("Макc " +
                "", 50);
            strBild.Append(new char[] { 'Ф', 'р', 'а', 'й' });
            strBild.Insert(0, "Большая телега ххх");
            strBild.Remove(15, 3);
            System.Console.WriteLine("Строка созданная с помощью StringBuilder:{0}", strBild.ToString());

            //  Создайте целый двумерный массив и выведите его на консоль в отформатированном виде (матрица). 

            int[,] arr = { { 4, 5, 7 }, { 7, 3, 8 }, { 3, 4, 6 } };
            System.Console.WriteLine("Двумерный массив(матрица):");
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                for (int q = 0; q < arr.GetLength(1); q++)
                {
                    System.Console.Write("\t" + arr[k, q]);
                }
                System.Console.WriteLine();
            }

            // Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. 
            // Поменяйте произвольный элемент(пользователь определяет позицию и значение).
            string[] arrString = { "Stark", "Rogers", "Banner" };
            System.Console.Write("Одномерный массив длинной {0}:", arrString.GetLength(0));
            foreach(string k in arrString) { System.Console.Write(" " + k); }
            System.Console.WriteLine();
            arrString[2] = "Thor";
            System.Console.Write("Изменённый массив:");
            foreach (string k in arrString) { System.Console.Write(" " + k); }
            System.Console.WriteLine();

            //Создайте ступечатый(не выровненный) массив вещественных чисел с 3 - мя строками, в каждой 
            //из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли

            float[][] jaggetArr = new float[3][];
            jaggetArr[0] = new float[2];
            jaggetArr[1] = new float[3];
            jaggetArr[2] = new float[4];
            System.Console.Write("Заполните ступенчатый массив:");
            for (int k = 0;k < jaggetArr.Length;k++)
            {
                System.Console.WriteLine("Строка {0}:",k+1);
                for (int q = 0; q < jaggetArr[k].Length; q++)
                {
                    jaggetArr[k][q] = Convert.ToSingle(System.Console.ReadLine());
                }
            }
            System.Console.WriteLine("Полученная ступенчатая матрица:");
            foreach(float[] k in jaggetArr )
            {
                foreach(float q in k)
                { System.Console.Write("\t\t" + q); }
                System.Console.WriteLine();
            }

            //Создайте неявно типизированные переменные для хранения массива и строки. 
            var varArray = new[] { 3, 5, 6, 7, 3, 5, 6, 57, 7, 67, 4, 4, 657, 7, 67, 76, 67, 435 };
            var varString = "";

            //Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.

            (int fir, string se, char th, string fo, ulong fif) tuple = (19, "Hamm", 'B', "Bette", 4532);
            // Выведите кортеж на консоль целиком и выборочно (1, 3, 4  элементы) 
            System.Console.WriteLine($"Кортеж целиком: {tuple} ");
            System.Console.WriteLine("Первый элемент кортежа: {0}",tuple.fir);
            System.Console.WriteLine("Третий элемент кортежа: {0}", tuple.th);
            System.Console.WriteLine("Четвёртый элемент кортежа: {0}", tuple.fo);
            // Выполните распаковку кортежа в переменные. 
            var (fir, se, th, fo, fif) = tuple;
            System.Console.WriteLine("Распокованный кортеж: {0},{1},{2},{3},{4} ", fir, se, th, fo, fif);
            //Сравните два кортежа.
            (int, string, char, string, ulong) tuple2 = (19, "Hamm", 'B', "Bette", 4532);
            System.Console.WriteLine("Сравнение кортежей: {0}", tuple.Equals(tuple2));

            //Создайте локальную функцию в main и вызовите ее. Формальные параметры функции – 
            //массив целых и строка. Функция должна вернуть кортеж, содержащий:
            //максимальный и минимальный элементы массива, сумму элементов массива и первую букву строки 

            (int,int,int,char) LocalF(int[] mass, string strok)
            {
                int max;
                int min;
                int sum=0;
                char symbol;
                Array.Sort(mass);
                max = mass[mass.Length - 1];
                min = mass[0];
                foreach(int k in mass)
                    sum += k;
                symbol = strok[0];
                return (max, min, sum, symbol);
            }
            int[] array = { 1, -4, 5, 6, 123, -67, 234, -32 };
            (int, int, int, char) kor = LocalF(array, "Bazinga");

            System.Console.WriteLine($"Результаты вычислений локальной функции(кортеж):{kor}");
            System.Console.ReadKey();
        }
    }
}
