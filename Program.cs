using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Assignment6
{
    class person
    {
        public  string name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1 Value Type
            /* Passing by vlue means that the function deals with a copy of the data and the changes(Logic)
             * that function does does not affect the original data, while passing by reference means that 
             * the fuction deals with original refernce of the data so any chages will affect the original data.
             */
            int number = 5;
            #region passing by value
            ChangeValue(number);
            //Console.WriteLine(number);//5
            #endregion
            #region passing by reference
            ChangeValue(ref number);
            //Console.WriteLine(number);//10
            #endregion
            #endregion
            #region Question2 Reference Type
                /*When we pass a reference type by its value the function deals with  a copy of the original array
                 * so it can modify its elements but, can not resize it so if create a new array within the function 
                 * body it will be an isolated object.
                 * When we pass it by reference the function deals with the original ref so it can modify the elements
                 * and the array it self
                 */
                person p = new person();
                p.name = "ahmed";
            #region passing by value
            //Console.WriteLine(p.name); //ahmed
            //Console.WriteLine("----------after modificaiton----------------");
            //ChangePerson(p);
            //Console.WriteLine(p.name); // ali
            // the last created object in the function will not affect here

            #endregion
            #region Passing by reference
            //Console.WriteLine(p.name);
            //Console.WriteLine("----------after modificaiton----------------");
            //ChangePerson( ref p);
            //Console.WriteLine( p.name);
            #endregion

            #endregion
            #region Question3 Out paramter
            //int num1 = 10;
            //int num2 = 20;
            //int sum;
            //int sub;
            //DoSomeOperation(num1,num2, out sum,out sub);
            //Console.WriteLine($"Sum is :  {sum}  sub is {sub}");
            #endregion
            #region Question4
            //Console.WriteLine("Please Enter the number: ");
            //string inputNumber=Console.ReadLine();
            //Console.WriteLine(SumDigits(inputNumber));
            #endregion
            #region Question5
            //Console.WriteLine(isPrime(26));
            #endregion
            #region Question6
            //int max = 0;
            //int min = 0;
            //int[] array = [55, 4, 66, 1, 7, 0];
            //returnMax(array,ref max);
            //Console.WriteLine($"max is :{max}");
            //returnMin(array,ref min);
            //Console.WriteLine($"min is : {min}");

            #endregion
            #region Question7
            //Console.WriteLine("Please the number :");
            //int.TryParse(Console.ReadLine(), out int input);
            //Console.WriteLine(CalculateFactorial(input));
            #endregion
            #region Question8
            //char[] chars = { 'A', 'B', 'C' };
            //changeChar(chars);
            //foreach (char c in chars)
            //{
            //    Console.Write($"{c,4}");
            //}

            #endregion

        }
        #region Functions For Q1
        public static void ChangeValue(int number)
        {
            number = 10;
        }
        public static void ChangeValue(ref int number)
        {
            number = 10;
        }
        #endregion
        #region Functions For Q2
        public static void ChangePerson(person p) // Passing by value
        {
            p.name = "Ali 'Modified from function'"; // will affect the input object 
            p = new person();// will not affect the input object cause it is passed by its value and will create another object with a different address
            p.name = "khaled";
        }
        public static void ChangePerson(ref person p) // Passing by reference
        {
            p.name = "Ali 'Modified from function'"; // will affect the input object 
            p = new person();// will  affect the input object cause it is passed by its reference and will make the original ref points at this object.
            p.name = "khaled";
        }
        #endregion
        #region Function For Question3
        public static void DoSomeOperation(int num1, int num2, out int sum, out int sub)
        {
            sum = 0;
            sub = 0; // When using the output paramter when must assign a value to it in  all different tracks of the function
            try
            {
                sum = num1 + num2;
                sub = num2 - num1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
            
        }
        #endregion
        #region Function For Question4
        public static int SumDigits(string number)
        {
            int sum = 0;
            int num;
            char[] numberArray=number.ToCharArray();
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (char.IsDigit(numberArray[i]))
                {
                   num= int.Parse(numberArray[i].ToString());
                    sum += num;
                }
            }
            return sum;
        }
        #endregion
        #region Function For Question5
        public static bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if(number%i== 0)
                    return false;
            }
            return true;
        }
        #endregion
        #region Function For Q6
        public static int returnMin(int[] array,ref int min)
        {
            min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        public static int returnMax(int[] array,ref int max)
        {
             max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        #endregion
        #region Function For Q7
        public static int CalculateFactorial(int num)
        {
            int fact = num;
            for (int i = 1; i < num; i++)
            {
                fact=fact*i;
            }
            return fact;
        }
        #endregion
        #region Function For Question8
        public static void changeChar(char[] chars)
        {
            chars[0] = 'N';
        }
        #endregion
    }
}
