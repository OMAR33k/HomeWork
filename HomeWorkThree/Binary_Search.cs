using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, r, p, key;
            int[] ar = {1,2,3,4,5,6,7,8,9,10};
            l = 0;
            r = 9;
            key = 9;
            p = ternarysearch(l, r, key, ar);
            Console.WriteLine("Index Of "+key+" IS "+p);
            Console.ReadKey();
        }
        static int ternarysearch(int l,int r,int key ,int[]ar)
        {
            if (r >= l)
            {
                int mid1 = l + (r - l) / 3;
                int mid2 = r - (r - l) / 3;
                if (ar[mid1]==key)
                {
                    return mid1;
                }
                if(ar[mid2]==key)
                {
                    return mid2;
                }
                if(key<ar[mid1])
                {
                    return ternarysearch(l, mid1 - 1, key, ar);
                }
                else if(key>ar[mid2])
                {
                    return ternarysearch(mid2 + 1, r, key, ar);
                }
                else
                {
                    return ternarysearch(mid1+1,mid2-1,key,ar);
                }
            }
            return -1;
        }
    }
}
