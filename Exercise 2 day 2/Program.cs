using System;

namespace Exercise_2_day_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int age, height, heartrate; 
            age = 27;
            height = 170;
            heartrate = 220 - age;

            Console.WriteLine("My age is " +age+ " , my max heart rate is " +heartrate+ " and my height is " +height+ " .");
        }
    }
}
