using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
            Console.WriteLine(findMedian(arr2));

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadKey();
        }

        //Naman: I liked working on this assignment.
        // 7th question was challenging for me and helped me in learning. 
        //It brushed up my concepts on loops, arrays and dictionaries.


        static void displayArray(int[] arr)
        {
            Console.WriteLine();
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            return new int[] { };
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            int sum = 0;
            int count = 0;
            // bubble sort: lowest to highest
            int temp = 0;

            for (int x = 0; x < prices.Length; x++)
            {
                for (int y = 0; y < prices.Length - 1; y++)
                {
                    if (prices[y] > prices[y + 1])
                    {
                        temp = prices[y + 1];
                        prices[y + 1] = prices[y];
                        prices[y] = temp;
                    }
                }
            }

            // now performing basic count increase 

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < k && sum < k)
                {
                    sum = sum + prices[i];

                    if (sum <= k)
                    {
                        count++;
                    }

                }
            }
            return count;
        }

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            return "";
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            return new int[] { };
        }


        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            return new int[] { };
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            int temp = 0;
            for (int x = 0; x < arr.Length; x++)  // sorting the array for computation
            {
                for (int y = 0; y < arr.Length - 1; y++)
                {
                    if (arr[y] > arr[y + 1])
                    {
                        temp = arr[y + 1];
                        arr[y + 1] = arr[y];
                        arr[y] = temp;
                    }
                }
            }


            int medianNumber; //declaring int for storing int type
            int index = (arr.Length - 1) / 2; //new int type INDEX for storing median value

            medianNumber = arr[index]; // saving value of array of index

            return medianNumber;
        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {

            int temp = 0;
            int diff = 0;

            for (int x = 0; x < arr.Length; x++) // sorting through array
            {
                for (int y = 0; y < arr.Length - 1; y++)
                {
                    if (arr[y] > arr[y + 1])
                    {
                        temp = arr[y + 1];
                        arr[y + 1] = arr[y];
                        arr[y] = temp;
                    }
                }
            }

            Dictionary<int[], int> arr1 = new Dictionary<int[], int>(); // using dictionary for computation
            for (int i = 0; i < arr.Length - 1; i++) // looping over dictionary to find all the differences possible
            {

                diff = arr[i + 1] - arr[i];
                int[] tempArray = { arr[i], arr[i + 1] };
                arr1.Add(tempArray, diff);

            }
            var min = arr1.Min(x => x.Value); // taking min difference

            ArrayList finalre = new ArrayList();
            var arrayF = arr1.Where(x => x.Value == min).ToList(); // converting to list

            foreach (var item in arrayF) //looping over arrayF
            {
                foreach (var k in item.Key)
                {
                    finalre.Add(k);
                }
            }

            return finalre.OfType<int>().ToArray(); //returning as int array
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            string dateR;
            string yearR = "";
            if (year >= 1700 && year <= 1917) // checking values between 1700 and 1917
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) // leap year logic for all the years
                {
                    yearR = year.ToString();
                    dateR = "12.09." + yearR;
                    return dateR;
                }
                else if (year == 1700) //particular year check
                {
                    yearR = year.ToString();
                    dateR = "12.09." + yearR;
                    return dateR;
                }
                else if (year == 1800) ////particular year check
                {
                    yearR = year.ToString();
                    dateR = "12.09." + yearR;
                    return dateR;
                }
                else if (year == 1900)  //particular year check
                {
                    yearR = year.ToString();
                    dateR = "12.09." + yearR;
                    return dateR;
                }
                else // for all the year except the above 3
                {
                    yearR = year.ToString();
                    dateR = "13.09." + yearR;
                    return dateR;
                }
            }
            else if (year == 1918) ////particular year check
            {
                yearR = year.ToString();
                dateR = "26.09." + yearR;
                return dateR;
            }
            else if (year > 1918) // after year 1918
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))  // leap year logic
                {
                    yearR = year.ToString();
                    dateR = "12.09." + yearR;
                    return dateR;
                }
                else
                {
                    yearR = year.ToString();
                    dateR = "13.09." + yearR;
                    return dateR;
                }

            }

            return "";
        }
    }
}
