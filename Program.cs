using System;

namespace RegexPatternMatchingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Pattern pattern = new Pattern();
                //bool result=pattern.validatePinCode("841423");
               // bool result = pattern.validateName("Vijay Krishna");
               bool result = pattern.validateEmail("abc@1.com");
                // bool result = pattern.validatePhone("91 8507047235");
              
                //bool result = pattern.validatePassword("Hellohello@1");

                Console.WriteLine(result);
                Console.ReadKey();
            }


        }
    }
}
