using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heapsort
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void BuildHeap(int[]arr)
        {
            int i = 0;
            int parent = arr[i];
            int childIndex, parentIndex; 
            for(i=1;i<arr.Length;i++)
            {
                InsertNode(arr[i], parent, arr);
            }

        }

        static void InsertNode(int node,int parent,int[] arr)
        {
            int parentIndex, childIndex; 
            if(node<=parent)
            {
                parentIndex = Array.IndexOf(arr, parent);
                childIndex = 2 * parentIndex + 1;
            }
            else
            {
                parentIndex = Array.IndexOf(arr, parent);
                childIndex = 2 * parentIndex + 2;
            }
            if(arr[childIndex]!=0)
            {
                InsertNode(node, arr[childIndex], arr);
            }
            else
            {
                arr[childIndex] = node;
            }
        }
    }
}
