using System;

namespace Test
{
 
        struct User
        {
            public string name;
            public int age;

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name}  Age: {age}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                User tom;
                tom.name = "Tom";
                tom.age = 34;
                tom.DisplayInfo();

                Console.ReadKey();
            }
        }
    }
  
    

