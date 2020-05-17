using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                ProcessBmi();
            }
        }

        public static void ProcessBmi()
        {
            string name = PromptString("Name");

            string surname = PromptString("Surname");

            int age = PromptInt("Age");

            float weight = PromptFloat("Weight(kg)");

            float heightCM = PromptFloat("Height(cm)");
            float heightM = heightCM / 100.0f;

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + heightCM + " cm.");

            float BMI = CalculateBmi(weight, heightM);
            Console.WriteLine("His Body-Mass Index(BMI) is " + BMI);
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
                
            return input;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) return 0;

            bool isNumber = int.TryParse(input, out int number);
            if (!isNumber || number < 0)
            {
                Console.Write("\"" + input + "\"" + " is not a valid number.");
                return -1;
            }
                
            return number;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) return 0;

            bool isNumber = float.TryParse(input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float number);
            if (!isNumber || number < 0.00f)
            {
                Console.Write("\"" + input + "\"" + " is not a valid number.");
                return -1.00f;
            }
                
            return number;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 && height <= 0) {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");

                return -1.00f;
            }

            else if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0) Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                if (height <= 0) Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");

                return -1.00f;
            }
            return weight / (height * height);
        }
    }
}
