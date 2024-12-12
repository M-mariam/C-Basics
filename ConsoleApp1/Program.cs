using System;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("enter any number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is " + number);
            ////2
            //string age = "twenty";
            //int intvar = int.Parse(age);
            //Console.WriteLine(intvar);
            // - > no error but (int.Parse) in the run time cause an error as the value is not a number

            //3
            float num1 = 5.5f;
            float num2 = 6.6f;
            float result = num1 + num2;
            Console.WriteLine(result);

            //4
            Console.WriteLine("enter any Word");
            string StringVar = Console.ReadLine();
            Console.WriteLine("enter any number");
            int numvar = int.Parse(Console.ReadLine());
            Console.WriteLine(StringVar.Substring(numvar));

            ////5 
            int num01 = 10;
            int num02 = num01;
            Console.WriteLine("originalValue: " + num01);
            Console.WriteLine("anotherValue: " + num02);
            num02 = 50;
            Console.WriteLine("After modifying anotherValue:");
            Console.WriteLine("originalValue: " + num02);

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
