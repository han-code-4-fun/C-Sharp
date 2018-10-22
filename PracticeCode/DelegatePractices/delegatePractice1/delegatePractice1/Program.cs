using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate bool NumberFilter<T>(T input);
delegate void AnotherDelegate();//Delegate -> MulticastDelegate -> AnotherDelegate
delegate int ReturnNumber();
delegate T GenericDelegate<T>();

namespace delegatePractice1
{

    class Program
    {
        #region FirstTest, delegate and lambda
        //static bool LessThan5(int n) { return n < 5; }
        //static bool LessThan10(int n) { return n < 10; }
        //static bool GreaterThan13(int n) { return n > 13; }
        #endregion

        static void Main(string[] args)
        {
            #region  FirstTest, delegate and lambda
            //IEnumerable<int> numberSet = FillWithNumbers();

            //IEnumerable<int> output = ReturnNumberUseDelegate(numberSet, LessThan5);

            //foreach(int i in output)
            //    Console.WriteLine(i);

            //IEnumerable<int> output2 = ReturnNumberUseDelegate(numberSet, n =>n >20);
            //foreach (int i in output2)
            //    Console.WriteLine(i);
            #endregion

            #region Second Delegate is a chain
            //AnotherDelegate Test2Delegate = Foo;

            //Test2Delegate += Goo;
            ////This is complier do  Test2Delegate= 
            ////(AnotherDelegate)Delegate.Combine(Test2Delegate, new AnotherDelegate(Goo));
            //Test2Delegate += Hoo;
            //Test2Delegate += Goo;

            //foreach(AnotherDelegate a in 
            //    Test2Delegate.GetInvocationList())
            //{
            //    Console.WriteLine(a.Target + " : " + a.Method);
            //}


            //Test2Delegate();
            #endregion


            #region ThirdTest
            //ReturnNumber RN = Return5;
            //RN += Return10;
            //RN += Return22;

            //Console.WriteLine(RN());//22


            //foreach(int i in GetAllReturnValue(RN))
            //    Console.WriteLine(i);
            #endregion


            GenericDelegate<int> d = Return5;
            d += Return10;
            d += Return22;

            foreach (int i in GetAllReturnValue(d))
            {
                Console.WriteLine(i);
            }

            /*
             * the result is 
             *  5
                Int32 Return5()
                10
                Int32 Return10()
                22
                Int32 Return22()

             *BECAUSE the yield and calling method in line 75
             
             */

            Console.ReadLine();
            
        }

        #region  FirstTest, delegate and lambda
        //static IEnumerable<int> ReturnNumberUseDelegate(
        //    IEnumerable<int> numbers, NumberFilter<int> numFilter)
        //{
        //    foreach (int num in numbers)
        //    {
        //        if (numFilter(num))
        //            yield return num;
        //    }
        //}



        //#region Duplicate methods
        ////static IEnumerable<int> AllNumberLessThanFive(
        ////    IEnumerable<int> numbers)
        ////{
        ////    foreach(int num in numbers)
        ////    {
        ////        if (num < 5)
        ////            yield return num;
        ////    }
        ////}
        ////static IEnumerable<int> AllNumberLessThanTen(
        ////   IEnumerable<int> numbers)
        ////{
        ////    foreach (int num in numbers)
        ////    {
        ////        if (num < 10)
        ////            yield return num;
        ////    }
        ////}
        ////static IEnumerable<int> AllNumberGreaterThanThirteen(
        ////  IEnumerable<int> numbers)
        ////{
        ////    foreach (int num in numbers)
        ////    {
        ////        if (num > 13)
        ////            yield return num;
        ////    }
        ////}
        //#endregion


        //static IEnumerable<int> FillWithNumbers()
        //{
        //    Random r = new Random();
        //    List<int> temp = new List<int>();
        //    for (int i = 0; i < 30; i++)
        //    {
        //        temp.Add(r.Next(0, 30));
        //    }
        //    return temp;
        //}
        #endregion

        #region Second Delegate is a chain
        //static void Foo() { Console.WriteLine("foo"); }
        //static void Goo() { Console.WriteLine("goo"); }
        //static void Hoo() { Console.WriteLine("hoo"); }
        #endregion

        #region ThirdTest


        //static int Return5() { return 5; }
        //static int Return10() { return 10; }
        //static int Return22() { return 22; }


        //static List<int> GetAllReturnValue(ReturnNumber input)
        //{
        //    List<int> tempInts = new List<int>();
        //    foreach (ReturnNumber element in input.GetInvocationList())
        //    {
        //        tempInts.Add(element());
        //        Console.WriteLine(element.Method);

        //    }
        //    return tempInts;
        //}

        #endregion


        static int Return5() { return 5; }
        static int Return10() { return 10; }
        static int Return22() { return 22; }
        static IEnumerable<T> GetAllReturnValue<T>
            (GenericDelegate<T> input)
        {
           
            foreach (GenericDelegate<T> element in input.GetInvocationList())
            {
                yield return element();
                Console.WriteLine(element.Method);

            }
          
        }
    }
}
