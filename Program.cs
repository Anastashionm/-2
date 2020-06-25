using System;

public class Program
{
    public static void Main()
    {
        //ввод размера массива и самого массива с консоли
        int n;
        Console.Write("insert N ");
        n = Int32.Parse(Console.ReadLine());
        double[] masiv = new double[n];
        Console.Write("insert masiv ");
        for (int i = 0; i < n; i++)
            masiv[i] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("=========");
        //ввод завершен


        //double[] masiv = new double[3]{-3,2,1}; // ввод массива из программы

        double Sum = 0;
        double max = 0;
        double min = Math.Abs(masiv[0]);
        int maxindex = -1;
        int minindex = 0;
        double Pr = 1;
        int tmp = 0;

        for (int i = 0; i < masiv.Length; i++)  // цикл. Проходим весь массив
        {
            if (masiv[i] > 0) //  проверяем элемент (положительный?)
                Sum = Sum + masiv[i]; // находим сумму
            if (Math.Abs(masiv[i]) > max) //  ищем максимальный по модулю элемент и его индекс
            {
                max = Math.Abs(masiv[i]);
                maxindex = i;
            }
            if (Math.Abs(masiv[i]) < min) //  ищем минимальный по модулю элемент и его индекс
            {
                min = Math.Abs(masiv[i]);
                minindex = i;
            }
        }

        if (minindex > maxindex) // сортируем индексы
        {
            tmp = minindex;
            minindex = maxindex;
            maxindex = tmp;
        }

        for (int i = minindex + 1; i < maxindex; i++) // пробегаем массив от минимального к максимальному индексу
            Pr = Pr * masiv[i]; //находим произведение

        Console.WriteLine("Sum: " + Sum);   // вывод суммы
        if (maxindex - minindex > 1)
            Console.WriteLine("Composition between " + minindex + " and " + maxindex + " elements: " + Pr);   // вывод произведения
        else
            Console.WriteLine("There no elements between " + minindex + " and " + maxindex);   // вывод сообщения об отсутствии элементов


        Console.Write("Array: ");
        for (int i = 0; i < masiv.Length; i++)
            Console.Write(" " + masiv[i]);      // вывод всего массива

        Array.Sort(masiv);          // сортировка
        Array.Reverse(masiv);       // переворот, сортировка становится по убыванию

        Console.Write("\nArray after sorting:");
        for (int i = 0; i < masiv.Length; i++) // вывод отсортированного массива
            Console.Write(" " + masiv[i]);
    }

}