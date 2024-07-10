using System;
using System.Runtime.CompilerServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question_2_func:
            static void Larg()
            {
                Console.Write("Enter Coma separated Numbers >> ");
                string[] Arr = Console.ReadLine().Split(',');
                int[] ints = new int[Arr.Length];
                for (int i = 0; i < Arr.Length; i++)
                {
                    ints[i] = int.Parse(Arr[i]);
                }
                int largest = ints[0];
                int SecLargest = ints[1];
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (ints[i] > largest)
                    {
                        SecLargest = largest;
                        largest = ints[i];
                    }
                    else if (ints[i] > SecLargest && ints[i] != largest)
                    {
                        SecLargest = ints[i];
                    }
                }
                if (largest != SecLargest)
                {
                    Console.WriteLine($"Largest value is {largest}");
                    Console.WriteLine($"Second largest value is {SecLargest}");
                }
                else
                {
                    Console.WriteLine("All entries are equal ");
                }

            }
            //Question_3_func:
            static void zer()
            {
                Console.Write("Enter Coma separated Numbers >> ");
                string[] arr = Console.ReadLine().Split(',');
                int[] ints = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    ints[i] = int.Parse(arr[i]);
                }
                int A = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (ints[i] != 0)
                    {
                        ints[A] = ints[i];
                        A++;
                    }
                }
                for (int i = A; i < ints.Length; i++)
                {
                    ints[i] = 0;
                }
                foreach (int i in ints)
                {
                    Console.WriteLine(i);
                }
            }
            //Question_4_func:
            static char FindFirstNonRepeating()
            {
                Console.Write("Enter a string >>");
                string str = Console.ReadLine();
                int[] charCount = new int[256];
                for (int i = 0; i < str.Length; i++)
                {
                    charCount[str[i]]++;
                }
                for (int i = 0; i < str.Length; i++)
                {
                    if (charCount[str[i]] == 1)
                    {
                        return str[i];
                    }
                }
                return '\0';
            }
            //Function_of_Question_5:
            static int[] MergeSortedArrays(int[] A, int[] B)
            {
                int[] mergedArray = new int[A.Length + B.Length];
                int i = 0, j = 0, k = 0;

                while (i < A.Length && j < B.Length)
                {
                    if (A[i] < B[j])
                    {
                        mergedArray[k++] = A[i++];
                    }
                    else
                    {
                        mergedArray[k++] = B[j++];
                    }
                }
                while (i < A.Length)
                {
                    mergedArray[k++] = A[i++];
                }
                while (j < B.Length)
                {
                    mergedArray[k++] = B[j++];
                }

                return mergedArray;
            }
            //This function is made to print arrays.
            static void PrintArray(int[] array)
            {
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();

            }


            //Question_2:
            //Larg();

            //Question_3:
            zer();

            //Question_4;
            //char firstNonRepeating = FindFirstNonRepeating();
            //Console.WriteLine($"First non-repeating character: {firstNonRepeating}");

            //Question_5:
            int[] A = { 1, 3, 5, 7 };
            int[] B = { 2, 4, 6, 8 };

            int[] mergedArray = MergeSortedArrays(A, B);

            Console.WriteLine("Merged array:");
            PrintArray(mergedArray);


        }
    }
}