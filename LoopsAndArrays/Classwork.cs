using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LoopsAndArrays
{
    public class ClassWork
    {
        public void bubleSortAray()
        {
            int length = 0;

            while (true) {
                Console.Write("Array Length: ");
                var lengthString = Console.ReadLine();

                if (int.TryParse(lengthString, out length))
                    break;
                else
                    {
                        Console.WriteLine("Length should be integer!");
                        continue;
                    }
            }

            int[] myArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Element number {i} is: ");
                var elementString = Console.ReadLine();

                if (int.TryParse(elementString, out myArray[i]))
                    continue;
                else
                {
                    Console.WriteLine("element should be integer!");
                    i--;
                    continue;
                }
            }

            int temp = 0;

            for (int j = 0; j < length; j++)
            {
                for (int i = 1; j < length; j++)
                {
                    if (myArray[j] < myArray[j - 1])
                    {
                        temp = myArray[j];
                        myArray[j] = myArray[j - 1];
                        myArray[j - 1] = temp;
                    }
                    else
                        continue;
                }
            }
            

            Console.Write("Sorted Array: ");
            for (int i = 0;i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
        }
    }
}
