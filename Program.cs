using System;
using System.Collections.Generic;



namespace unbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            //Box some string data into a variable
            List<object> BoxedDataList =new List<object>();
            BoxedDataList.Add(7);
            BoxedDataList.Add(28);
            BoxedDataList.Add(-1);
            BoxedDataList.Add(true);
            BoxedDataList.Add("chair");

            foreach (var item in BoxedDataList)
            {
                if(item is int)
                {
                    Console.WriteLine("Unbox int is: " + (int)item);
                    sum = sum + (int)item;
                }
                 if (item is string)
                 {
                     Console.WriteLine("Unbox string is: " + (string)item);
                 }
                if (item is bool)
                {
                    Console.WriteLine("Unbox bool is: " + (bool)item);
                }
                 
            }

            Console.WriteLine("Unbox sum is: " + (int)sum);

// //Make sure it is the type you need before proceeding
// if (BoxedData is int) {
//     //This shouldn't run
//     Console.WriteLine("I guess we have an integer value in this box?");
// }
// if (BoxedData is string) {
//     Console.WriteLine("It is totally a string in the box!");
// }


        //    List<string> bikes = new List<string>();
        }
    }
}
