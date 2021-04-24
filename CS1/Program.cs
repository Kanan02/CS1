using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            char c = '\0';
            int count = 0;
            while (c != '.')
            {
                c = (char)Console.Read();
                if (c == ' ') count++;

            }
            Console.WriteLine(count + " spaces were read.");
            Console.ReadLine();

            //Ex2
            int num;
            Console.WriteLine("Enter ticket code: ");
            num = int.Parse(Console.ReadLine());
            if ((num % 10 + (num / 10) % 10 + (num / 100) % 10) == ((num / 1000) % 10 + (num / 10000) % 10 + (num / 100000)))
            {
                Console.WriteLine("Lucky Ticket!");
            }
            else
            {
                Console.WriteLine("Unlucky Ticket!");

            }

            //Ex3
            string strex3 = Console.ReadLine();
            StringBuilder str2 = new StringBuilder();
            str2.Append(strex3);
            for (int i = 0; i < strex3.Length; i++)
            {
                if (str2[i] <= 122 && str2[i] >= 97) str2[i] = char.ToUpper(str2[i]);
                else if (str2[i] <= 90 && str2[i] >= 65) str2[i] = char.ToLower(str2[i]);

            }
            Console.WriteLine(str2);


            //Ex4
            Console.WriteLine("Enter A:");
            int A =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter B:");
            int B = int.Parse(Console.ReadLine());
            if (A > B)
            {
                A = A * B; //a=50 (5*10)      
                B = A / B; //b=5 (50/10)      
                A = A / B; //a=10 (50/5)
            }
            int[][] arr = new int[B-A+1][];
            int t = 0;
            for (int i = A; i < B + 1; i++)
            {
                arr[t] = new int[i];
                t++;
            }
            int k = 0;
            for (int i = A; i < B+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    arr[k][j]= i;
                }
                k++;
            }
        
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Enter a number: ");
            string number1 = Console.ReadLine();
            char[] charArray = number1.ToCharArray();
            Array.Reverse(charArray);
            number1 =new string( charArray);
            int number = int.Parse(number1);
            Console.WriteLine(number);
            
        }
    }
}
