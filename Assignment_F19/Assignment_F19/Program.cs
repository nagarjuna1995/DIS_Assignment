//Name: Kanneganti Nagarjuna

using System;

namespace Assignment_F19
{
    
namespace DIS_Assignment1
    {
        class Program
        {
            static void Main(string[] args)
            {
                int a = 1, b = 22;
                Console.WriteLine("Self dividing number are");
                printSelfDividingNumbers(a, b);



                int n2 = 5;

                Console.WriteLine(" The Series is");
                printSeries(n2);


                int n3 = 5;

                Console.WriteLine("The triangle is");
                printTriangle(n3);


                int[] J = new int[] { 1, 3 };
                int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
                int r4 = numJewelsInStones(J, S);
                Console.WriteLine("Number of jewels in stones are");
                Console.WriteLine(r4);


                int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
                int[] arr2 = new int[] { 1, 2, 5, 7, 8, 9};
                Console.WriteLine("The common sub array elements are");
                int[] r5 = getLargestCommonSubArray(arr1, arr2);
                for (int i = 0; i < r5.Length; i++)
                {
                    Console.Write(r5[i] + " ");
                }



                //solvePuzzle();
                Console.ReadLine();
            }
            public static void printSelfDividingNumbers(int x, int y)
            {
                try
                {
                    // intializing the parameter to x;
                    // Handling x values if x is 0
                    int start = x;
                    if (x == 0)
                    {
                        start = x + 1;
                    }

                    else
                    {
                        // iterating over values given in the function
                        for (int i = start; i <= y; i++)
                        {
                            bool k = isSelfDividing(i); // passing to the function to know if it is self divisible or not
                            if (k == true) // if it is true then it is divisible and printing out that number
                            {
                                Console.Write(i); //Printing the value of i
                                Console.Write(" ");
                            }

                        }


                    }
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
                }
            }

            public static bool isSelfDividing(int x)
            {
                while (x > 0)
                {
                    int y = x % 10; // passing the remainder to y
                    if (y == 0)
                    {
                        return false;
                    }

                    else if (x % y == 0) // checking if it is divisible
                    {
                        x = x / 10; // saving the rest of digits of the number
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;

            }


            public static void printSeries(int n)
            {
                try
                {

                    int count = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        if (count <= n) // Checking the count variable
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (count < n) // checking if count is less than the given n
                                {
                                    Console.Write(i);
                                    count++; // increase the count
                                }


                            }


                        }
                        else

                        {
                            break;
                        }
                    }


                }
                catch
                {
                    Console.WriteLine("Exception occured while computing printSeries()");
                }
            }

            public static void printTriangle(int n)
            {
                try
                {
                    int i, j, k; // declaring variables for rows, columns and space


                    for (i = n; i >= 1; --i) //  loop for number of lines
                    {
                        for (k = 0; k < n - i; ++k) // loop for spacing horizontally
                        {
                            Console.Write(" ");
                        }
                        for (j = i; j <= 2 * i - 1; ++j) // using 2*i-1 for decreasing on both sides to achieve pyramid like structure
                        {
                            Console.Write("* ");
                        }
                        for (j = 0; j < i - 1; ++j) // looping for stars
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine(" ");
                    }


                }
                catch
                {
                    Console.WriteLine("Exception occured while computing printTriangle()");
                }
            }

            public static int numJewelsInStones(int[] J, int[] S)
            {
                try
                {

                    int n1 = J.Length; // recording the lengths
                    int n2 = S.Length;

                    int count = 0;
                    for (int i = 0; i < n1; i++)
                    {
                        for (int j = 0; j < n2; j++)
                        {

                            if (J[i] == S[j]) // checking if there are common elements
                            {
                                count++; // increasing the count of common elements
                            }

                        }



                    }
                    if (count == 0)
                    {
                        return 0; //returing the count
                    }
                    else
                    {
                        return count;
                    }


                }
                catch
                {
                    Console.WriteLine("Exception occured while computing numJewelsInStones()");
                }

                return 0;
            }

            public static int[] getLargestCommonSubArray(int[] a, int[] b)
            {
                try
                {

                    int max = 0; // for maximum length of the array
                    int len = 0; // len for updating the windows of sub arrays
                    int end = 0;
                    int i,j = 0;

                    for (i = 0; i < a.Length; i++)
                    {
                        if (j >= b.Length) break;
                        for (; j < b.Length; j++)
                        {
                            if (a[i] == b[j]) // comparing if there are any common elements
                            {
                                len++; // increase the length
                                j++; // increase J because after break, j won't be increased
                                break;
                            }
                            else
                            {
                                if (len >= max) // if length is greater than maximum
                                {
                                    max = len; // update max variable
                                    end = i - 1; // update the end of subarray
                                }
                                len = 0;   // update the length as zero as it subarray ends
                                if(a[i] < b[j]) // If a number of 1st array is less than second one, then break it as it is a sorted array
                                {
                                    break;
                                }

                                                               
                            }
                        }
                    }
                    if (len >= max) // check the max again after all iterations to update the end and the max
                    {
                        max = len;
                        len = 0;
                        end = i - 1;
                    }
                    j = 0;
                    int[] res = new int[max]; // declaring a new array of size max 
                    for (i = end - max + 1; i <= end; i++, j++) // storing the subarray elements in a new array
                    {
                        res[j] = a[i];
                    }
                    

                    return res;


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
                }
                return null;


            }

            public static void solvePuzzle()
            {
                try
                {
                    // Write your code here
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing solvePuzzle()");
                }
            }
        }
    }





}

