using System.Data;
using System.Dynamic;
using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_03_Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            Console.WriteLine("Enter search key:");
            int key =Convert.ToInt32(Console.ReadLine());
            Stopwatch sw=new Stopwatch();
            int res = -1;
            Console.WriteLine("==========================================");
            Console.WriteLine("Searching in intrative linear ...\n");
            sw.Start();
            res = Linear_Iterative(arr, key);
            sw.Stop();
            Console.WriteLine("key found at {0} index, time took {1} ms",res,sw.Elapsed);
            sw.Reset();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Searching in recursive linear ...");
            sw.Start();
            res = Linear_Recursive(arr, key);
            sw.Stop();
            Console.WriteLine("key found at {0} index, time took {1} ms", res, sw.Elapsed);
            sw.Reset();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Searching in recursive binary ...");
            sw.Start();
            res = Linear_Iterative(arr, key);
            sw.Stop();
            Console.WriteLine("key found at {0} index, time took {1} ms", res, sw.Elapsed);
            sw.Reset();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Searching in recursive binary ...");
            sw.Start();
            res = Linear_Recursive(arr, key);
            sw.Stop();
            Console.WriteLine("key found at {0} index, time took {1} ms",res,sw.Elapsed);
            sw.Reset();
            Console.WriteLine();
        }
        public static int Linear_Iterative(int[]arr,int key)
        {
            for(int i = 0; i < arr.Length;i++)
            {
                if(arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int Linear_Recursive(int[]arr,int key,int i=0)
        {
            if(arr.Length == i)
            {
                return -1;
            }
            if (arr[i] == key)
            {
                return i;
            }
            return Linear_Recursive(arr, key, i+1);
        }
        public static int Binary_Recursive(int[]arr,int key ,int start,int end)
        {
            int mid = (start+end)/2;
            if(arr[mid]==key)
            {
                return mid;
            }
            if(start>end)
            {
                return -1;
            }
            if(arr[mid]>key)
            {
                return Binary_Recursive(arr,key,start,mid-1);
            }
            return Binary_Recursive(arr,key,mid+1,end);
        }
        public static int Binary_Iterative(int[]arr,int key)
        {
            int start = 0;
            int end=arr.Length-1;
            while(start<=end)
            {
                int mid =(start+end)/2;
                if(arr[mid] == key)
                {
                    return mid;
                }
                if(arr[mid]>key)
                {
                    end = mid - 1;
                }
                if(arr[mid]<key)
                {
                    start = mid + 1;
                }
            }
            return -1;
        }

    }
}
