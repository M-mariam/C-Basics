using System;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is " + num);
            #endregion


            #region Q2
            string age = "twenty";
            int intvar = int.Parse(age);
            Console.WriteLine(intvar);
            // - > no error but (int.Parse) in the run time cause an error as the value is not a number

            #endregion


            #region Q3

            float num1 = 5.5f;
            float num2 = 6.6f;
            float result = num1 + num2;
            Console.WriteLine(result);
            #endregion

            #region Q4
            Console.WriteLine("enter any Word");
            string StringVar = Console.ReadLine();
            Console.WriteLine("enter any number");
            int numvar = int.Parse(Console.ReadLine());
            Console.WriteLine(StringVar.Substring(numvar));
            #endregion



            #region Q5
            int num01 = 10;
            int num02 = num01;
            Console.WriteLine("originalValue: " + num01);
            Console.WriteLine("anotherValue: " + num02);
            num02 = 50;
            Console.WriteLine("After modifying anotherValue:");
            Console.WriteLine("originalValue: " + num02);
            #endregion

            //6
            #region Q6
            Point P01;
            P01 = new Point();
            Console.WriteLine(P01.x);

            Point P02 = new Point();
            P02.x = 12;
            P02 = P02;
            Console.WriteLine(P02.x);
            #endregion


            //7
            #region Q7
            Console.WriteLine("enter your Fname");
            string Fname = Console.ReadLine();
            Console.WriteLine("enter your Fname");
            string Lname = Console.ReadLine();
            Console.WriteLine("fullname is :" + Fname + Lname);
            #endregion


            //8

            #region Q8 
            Console.WriteLine("enter Princible number");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter Rate");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter time");
            double time = Convert.ToDouble(Console.ReadLine());
            double simpleIntrest = (principle * rate * time) / 100;
            Console.WriteLine("The simple intrest is" + simpleIntrest);

            #endregion

            //9
            #region Q9

            Console.WriteLine("enter your weight in KiloGrams");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = (weight) / (height * height);
            Console.WriteLine("The Body Mass Index (BMI) is: " + bmi);

            #endregion


            #region Q10

            Console.Write("Enter the temperature in degrees: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            string results = temperature < 10 ? "Just Cold" :
                            temperature > 30 ? "Just Hot" : "Just Good";
            Console.WriteLine("The temperature is: " + results);
            #endregion


            //11
            #region Q11

            Console.Write("Enter Any date");
            DateTime UserDate = Convert.ToDateTime(Console.ReadLine());
            string FormatedDate = string.Format($"Today’s date {UserDate: dd/MM/yyyy} {UserDate: dd,MM,yyyy}");
            Console.WriteLine(FormatedDate);
            #endregion

            #region Q12
            DateTime date = new DateTime(2024, 6, 14);
            Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //answer c
            #endregion


            #region Q13
            int d;
            d = Convert.ToInt32(!(30 < 20));
            // answer f
#endregion

            #region Q14        
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            // answer d
            #endregion


            #region Q15    
            int number = 1, z = 5;
            if (!(number <= 0))
                Console.WriteLine(++number + z++ + " " + ++z);
            else
                Console.WriteLine(--number + z-- + " " + --z);
            //answer d
            #endregion




























        }
    }
}
