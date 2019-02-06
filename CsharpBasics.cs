using System;

namespace CsharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800f;
            float mass = 14.6f;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string str1 = "Hello";
            string str2 = "Karen";

            //Comparing sample1 to sample2
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.\n");
            }
            else
            {
                Console.WriteLine("The samples are not equal.\n");
            }
            Console.ReadKey();

            //Heart Rate
            if (40 <= heartRate && heartRate <= 80)
            {
                Console.WriteLine("\n\nHeart Rate is normal.\n");
            }
            else
            {
                Console.WriteLine("\nHeart Rate is not normal.\n");
            }
            Console.ReadKey();

            //Deposit check
            if (deposits >= 100000000)
            {
                Console.WriteLine("\nYou are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("\nSorry you are so poor.\n");
            }
            Console.ReadKey();

            //Force 
            float force = 0.00f;
            force = mass * acceleration;
            Console.WriteLine("\n\nForce = {0}" , force);

            //Distance
            Console.WriteLine("\n\n{0} is the distance.\n", distance);

            //Lost and a Coupon
            if (lost == true && expensive == true)
            {
                Console.WriteLine("\n\nI am really sorry! I will get the manager.\n");
            }
            if (lost == true && expensive == false)
            {
                Console.WriteLine("\nHere is coupon for 10 % off.");
            }

            //Choices and switch statement
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nYou chose 1.\n");
                    break;
                case 2:
                    Console.WriteLine("\nYou chose 2.\n");
                    break;
                case 3:
                    Console.WriteLine("\nYou chose 3.\n");
                    break;
                default:
                    Console.WriteLine("\nYou made an unknown choice\n");
                    break; 
            }

            //Integral part
            Console.WriteLine("\n{0} is an integral", integral);

            //For loop 
            int i; 
            for(i = 5; i <= 10; i++)
            {
                Console.WriteLine("\ni = {0}\n", i);
            }

            //Age
            int age = 0;

            while (age < 6)
            {
                Console.WriteLine("\nage = {0}\n", age);
                age++;
            }

            //Greeting Screen
            String.Join(str1, str2);
            Console.WriteLine(str1 +  " " + str2);

        }
    }
}