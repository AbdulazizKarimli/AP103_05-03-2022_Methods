using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ValueReferance

            //int num = 5;
            //int num2 = num;

            //int[] arr = { 1, 2, 3 };
            //int[] arr2 = arr;
            //arr2[0] = 15;
            //int[] arr3 = { 1, 2, 3 };
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr3==arr);
            //Console.WriteLine(arr[0]==arr3[0]);
            //num2 = 15;
            //Console.WriteLine($"num= {num}");
            //Console.WriteLine($"num2={num2}");
            //Console.WriteLine($"sum= {5+5}");
            //Console.WriteLine("sum= " + (5+5));
            //Console.WriteLine("{0} {1} {2}",4,5);
            #endregion

            #region Methods

            //int total=  Sum(2,3);
            // Console.WriteLine("total");
            //string firstName = PrintName("Ehmed");
            // Console.WriteLine(firstName);
            //Info(5,9);
            //bool test = Compare(4, 5);
            //Console.WriteLine(test);

            //int num = 5;
            //int num2 = 10;
            //Console.WriteLine(Compare(num,num2));
            //Compare(6, 5);
            //Console.WriteLine(Multiple()); 
            //int[] numbers = { 1, 2, 4, 8, 13 };
            //int sum = Cem(new int[]{ 12,8,45,2});
            //int sum = Cem(6, 2, 3, 4, 8);
            //Console.WriteLine(sum);
            #endregion

            #region Method overloading
            //int total=Sum(5);
            //Console.WriteLine(total);

            //Console.WriteLine(Sum(5,1));
            #endregion
        }
        #region Methods
        //static int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}
        //static string PrintName(string name)
        //{
        //    return name;
        //}
        //static void Info(int x, int y)
        //{
        //    int num = x + y;
        //    Console.WriteLine(num);
        //    //Console.WriteLine($"Info method {word}");
        //}

        //static void Compare(int num1, int num2)
        //{
        //    if (num1 > num2)
        //    {
        //        Console.WriteLine("boyukdur");
        //        return;
        //    }
        //    Console.WriteLine("kicikdir");

        //}


        //static int Multiple(int num1=5,int num2=10)
        //{
        //    return num1 * num2;
        //}
        /// <summary>
        /// toplayir
        /// </summary>
        /// <param name="arr">int array qebul edir</param>
        /// <returns> int return ewdir</returns>
        //static int Cem(params int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i]%2==0)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}

        #endregion

        #region Method overloading

        //method signature
        //1. Methodun adi,
        //2.Methodun paramanetlerinin sayi,
        //3.methodun parametlerinin type-i
        //static int Sum(params int[] nums)
        //{
        //    return 0;
        //}

        //static int Sum(int num)
        //{
        //    return num;
        //}
        //static int Sum(int num,int num2 = 5)
        //{
        //    return num+num2;
        //}
        #endregion
    }
}
