namespace Assignment05
{
    internal class Program
    {

        //public static void Swap(ref int a , ref int b)
        //{
        //     int temp = a;
        //     a=b; 
        //     b=temp;    
        //}

        // public static int Multiple(int [] a)
        // {
        //     int result = 1;
        //     if (a is not null)
        //     {
        //         a[0] = 2;
        //         for (int i = 0; i < a.Length; i++)
        //             result *= a[i];
        //     }
        //     return result;

        // }
        // public static int Multiple2(ref int[] a)
        // {
        //     int result = 1;
        //     if (a is not null)
        //     {
        //         a = new int[] {5,6,7,8}; 
        //         for (int i = 0; i < a.Length; i++)
        //             result *= a[i];
        //     }
        //     return result;

        // }
        //public static void SumSub(int a , int b , out int sum , out int sub)
        //{
        //     sum=a+b;
        //     sub = a - b;
        //}

        //public static int SumDigits(int number)
        //{
        //    int sum = 0;
        //    while (number != 0)
        //    {
        //        int digit = number % 10;
        //        sum += digit;
        //        number /= 10;
        //    }
        //    return sum;

        //}
        //public static bool IsPrime(int n)
        //{
        //    if (n == 1) return false;
        //    for (int i = 2; i < n; i++) 
        //        if(n%i == 0) return false;
        //    return true; 
        //}
        //public static void MinMaxArray(ref int[] arr, ref int max , ref int min)
        //{
        //     max = int.MinValue;
        //     min = int.MaxValue;
        //    if (arr != null)
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if(arr[i] > max)    max= arr[i];
        //           if(arr[i] < min)    min= arr[i];
        //        }

        //}

        //public static int FactorialCalculate(int num)
        //{
        //    int fact = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        fact *= i;
        //    }
        //    return fact;
        //}

        public static String ChangeChar(string s , int pos , char c)
        {
            s=s.Remove(pos,1);
            s=s.Insert(pos,c.ToString());
            return s;   
        } 






        static void Main(string[] args)
        {
            #region Q1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            #region value Type parameters(by value)
            //int x = 3, y = 5;
            //Console.WriteLine($"x = {x}"); //3
            //Console.WriteLine($"y = {y}"); //5
            // Swap(x, y);
            //Console.WriteLine("After Swaping  ");
            //Console.WriteLine($"x = {x}"); //3
            //Console.WriteLine($"y = {y}"); //
            #endregion

            #region Value type parameters (by reference)
            //int a = 10, b = 5;
            //Console.WriteLine($"a = {a}"); //10
            //Console.WriteLine($"b = {b}"); //5
            //Swap(ref a, ref b);
            //Console.WriteLine("After Swaping");
            //Console.WriteLine($"a = {a}"); //5
            //Console.WriteLine($"b = {b}"); //10

            #endregion
            #endregion

            #region Q2.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            #region Reference type parameters (by value)
            //int[] arr = {1,2,3};
            //Console.WriteLine(arr[0]); //1
            //int result =Multiple(arr); 
            //Console.WriteLine(arr[0]); //2
            //Console.WriteLine(result); //12
            #endregion
            #region Reference type parameters (by reference )
            //int [] arr = { 1,2,3};
            //Console.WriteLine(arr[0]); //1
            //int result = Multiple2(ref arr); //5 6 7 8
            //Console.WriteLine(arr[0]); //5
            //Console.WriteLine(result); //1680
            #endregion
            #endregion

            #region Q3.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //  int a = 10, b = 5;
            //  int sum = 0 , sub = 0 ;
            //  SumSub(a, b, out sum, out sub);   
            //Console.WriteLine($"Sum is {sum}"); 
            //Console.WriteLine($"Sub is {sub}"); 


            #endregion

            #region Q4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given numbe
            //int num = 123;
            //int result = SumDigits(num);
            //Console.WriteLine(result);  

            #endregion
            #region Q5.Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            // int a = 2;
            //bool x= IsPrime(a); 
            // Console.WriteLine(x);


            #endregion
            #region Q6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int [] arr = { 1, 2, 3 ,5,6,7,8};  
            //int max = int.MinValue; 
            //int min = int.MaxValue;
            //MinMaxArray(ref arr, ref max , ref min );
            //Console.WriteLine($"Max is {max}");
            //Console.WriteLine($"Min is {min}");
            #endregion
            #region Q7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //int x = 5;
            //int result =FactorialCalculate(5);
            //Console.WriteLine(result);  
            #endregion
            #region Q8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
           // string str = "nada";
           //string newstr= ChangeChar(str, 1, 'c');
           // Console.WriteLine(newstr);  

            #endregion
        }

    }
}
