using System;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // datatype (value type) : stack

            //Point P01; //REFERENCE 
            // DCLARe reference from type 'point'
            //P01 : CAN REFER YO OBJECT FROM TYPE POINT

            // Console.WriteLine(P01);
            //P01 = new Point();
            // 1. allocate te number of req bytes for the object at heap
            // 2. intialized the allocated byte with the defualt value of the DT
            // 3. call user-defined constructor if exist 
            // 4. assign th object to the reference 'PO1'
            //Console.WriteLine(P01.y);

            // object
            //object O01;
            // Declare for reference from tye obj
            // O01 : can refere to instance from type obj or any type inherred

            //O01 = new object();
            //O01 = 1;
            //O01 = 'A';
            //O01 = new Point();
            //Console.Write(O01.ToString()); //{0,0}
            //Console.Write(O01.GetHashCode()); // id: indicate for the address of the obj

            //// 1
            //Console.WriteLine("enter any number");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("The number is " + num);
            //////2
            ////string age = "twenty";
            ////int intvar = int.Parse(age);
            ////Console.WriteLine(intvar);
            //// - > no error but (int.Parse) in the run time cause an error as the value is not a number

            ////3
            //float num1 = 5.5f;
            //float num2 = 6.6f;
            //float result = num1 + num2;
            //Console.WriteLine(result);

            ////4
            //Console.WriteLine("enter any Word");
            //string StringVar = Console.ReadLine();
            //Console.WriteLine("enter any number");
            //int numvar = int.Parse(Console.ReadLine());
            //Console.WriteLine(StringVar.Substring(numvar));

            ////5
            int num1 = 10;
            int num2 = num1;
            Console.WriteLine("originalValue: " + num1);
            Console.WriteLine("anotherValue: " + num2);
            num2 = 50;
            Console.WriteLine("After modifying anotherValue:");
            Console.WriteLine("originalValue: " + num2);

            //6
            Point P01;
            P01 = new Point();
            Console.WriteLine(P01.x);

            Point P02 = new Point();
            P02.x = 12;
            P02 = P02;
            Console.WriteLine(P02.x);

            //7
            Console.WriteLine("enter your Fname");
            string Fname = Console.ReadLine();
            Console.WriteLine("enter your Fname");
            string Lname = Console.ReadLine();
            Console.WriteLine("fullname is :" + Fname + Lname);

            //8
            Console.WriteLine("enter Princible number");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter Rate");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter time");
            double time = Convert.ToDouble(Console.ReadLine());
            double simpleIntrest = (principle * rate * time) / 100;
            Console.WriteLine("The simple intrest is" + simpleIntrest);

            //9
            Console.WriteLine("enter your weight in KiloGrams");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = (weight) / (height * height);
            Console.WriteLine("The Body Mass Index (BMI) is: " + bmi);

            //10

            Console.Write("Enter the temperature in degrees: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            string results = temperature < 10 ? "Just Cold" :
                            temperature > 30 ? "Just Hot" : "Just Good";
            Console.WriteLine("The temperature is: " + results);

            //11

            Console.Write("Enter Any date");
            DateTime UserDate = Convert.ToDateTime(Console.ReadLine());
            string FormatedDate = string.Format($"Today’s date {UserDate: dd/MM/yyyy} {UserDate: dd,MM,yyyy}");
            Console.WriteLine(FormatedDate);

            //12

            DateTime date = new DateTime(2024, 6, 14);
            Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //answer c

            //13
            int d;
            d = Convert.ToInt32(!(30 < 20));
            // answer f


            //14
            Console.WriteLine(13 / 2 + " " + 13 % 2);

            // answer d
            //15
            int num = 1, z = 5;


            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);
            //answer d































        }
    }
}
