// See https://aka.ms/new-console-template for more information




//using System;
//using System.Collections;

//namespace MethodNumbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] num = new int[5] { 20, 77, 118, 110, 115 };

//            for (int i = 0; i < num.Length; i++)
//            {
//                Console.WriteLine(num[i]);
//            }
//        }
//    }
//}



//using System;
//using System.Collections;

//namespace MethodNumbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] num = { 20, 77, 118, 110, 115 };

//            foreach (int item in num)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}





//using System;
//using System.Collections;

//namespace MethodNumbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] num = { 20, 77, 118 };

//            for (int i = 0; i < num.Length; i++)
//            {
//                Console.WriteLine(num[i]);
//            }
//                Console.WriteLine("****");

//            int d = AddNumbers(20, 77, 110);
//                Console.WriteLine(d);
//        }

//        static int AddNumbers(int a, int b, int c)
//        {
//            return  a + b + c;
//        }
//    }
//}


//using System;
//namespace ArrayApplication
//{
//    class MyArray
//    {
//        static void Main(string[] args)
//        {
//            int[] n = new int[100]; /* n is an array of 10 integers */
//            int i, j;

//            /* initialize elements of array n */
//            for (i = 0; i < 100; i++)
//            {
//                n[i] = i * 2;
//            }

//            /* output each array element's value */
//            for (j = 0; j < 100; j++)
//            {
//                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
//            }
//            Console.ReadKey();
//        }
//    }
//}

//Add the values in thousend Array and store it in SumOfThousndArray

//using System;
//using System.Collections;
//using System.Linq;

//namespace MethodNumbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int[] thousend = new int[50];

//            for (int i = 0; i < thousend.Length; i++)
//            {
//                Console.WriteLine(thousend[i] = i * 2);
//            }

//            int[] SumOfThousndArray = new int[0];

//            for (int j = 0; j > 50; ++j)
//            {
//                Console.WriteLine(SumOfThousndArray);
//            }

//            foreach (int i in thousend)
//            {
//                Console.WriteLine(SumOfThousndArray + "\t" + i);
//            }

//        }
//    }
//}



using System;
using System.Collections;
using System.Linq;

namespace MethodNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] bankAccounts = new int[1000];

            for (int i = 0; i < bankAccounts.Length; i++)
            {
                bankAccounts[i] = 100;
            }

            //1000 * 20 / 100
            //hello

            //20% intrests (sood)



            int allOfYourMoney = 0;

            for (int i = 0; i < bankAccounts.Length; i++)
            {
                allOfYourMoney = allOfYourMoney + bankAccounts[i];
            }

            

            //foreach (var item in bankAccounts)
            //{
            //    allOfYourMoney = allOfYourMoney + item;
            //}
            Console.WriteLine(allOfYourMoney);


        }
    }
}