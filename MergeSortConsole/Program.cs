using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] mainarray = new int[] { 4, 3, 2, 1 };
            //int[] mainarray = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] mainarray = new int[] { 45, 36, 18, 53, 72, 30, 48, 93, 15, 36 };
            try
            {
                MergeSort(mainarray,0,mainarray.Length-1);
                Console.WriteLine(String.Join(",", mainarray));
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }
        /// <summary>
        /// separate to two array and then merge
        /// </summary>
        /// <param name="array">input array</param>
        /// <param name="firstindex">the first index of input array(normal is 0)</param>
        /// <param name="lastindex">the last index of input array(normal is the array length -1)</param>
        public static void MergeSort(int[] array,int firstindex, int lastindex)
        {
           try
           {
                if(firstindex < lastindex)
                {
                    int middleindex = (firstindex + lastindex) / 2;
                    //Separate to two group using recursion
                    MergeSort(array, firstindex, middleindex);
                    MergeSort(array, middleindex + 1, lastindex);
                    //merge two sorted array
                    MergeArray(array, firstindex, middleindex, middleindex + 1, lastindex);
                }
           }
           catch (System.Exception ex)
           {
           	
           }
           finally
           {
           }   
        }
        /// <summary>
        /// merge two sorted array
        /// </summary>
        /// <param name="array">input array</param>
        /// <param name="firstindex">the first index of left array</param>
        /// <param name="leftmiddleindex">the last index of left array</param>
        /// <param name="rightmiddleindex">the first index of right array</param>
        /// <param name="lastindex">the last index of right array</param>
        public static void MergeArray(int[] array, int firstindex, int leftmiddleindex, int rightmiddleindex, int lastindex)
        {
            try
            {
                int leftindex = firstindex;
                int rightindex = rightmiddleindex;

                int[] temparr = new int[lastindex - firstindex+1];
                int tempindex = 0;
                while (leftindex <= leftmiddleindex && rightindex <= lastindex)
                {
                    if (array[leftindex] < array[rightindex])//order from small to high
                    {
                        temparr[tempindex] = array[leftindex];
                        leftindex = leftindex + 1;
                    }
                    else//array[leftindex] >= array[rightindex]
                    {
                        temparr[tempindex] = array[rightindex];
                        rightindex = rightindex + 1;
                    }
                    tempindex = tempindex + 1;
                }
                while(leftindex<=leftmiddleindex)//if left exists
                {
                    temparr[tempindex] = array[leftindex];
                    leftindex = leftindex + 1;
                    tempindex = tempindex + 1;
                }
                while (rightindex <= lastindex)//if right exists
                {
                    temparr[tempindex] = array[rightindex];
                    rightindex = rightindex + 1;
                    tempindex = tempindex + 1;
                }

                for(int i=0;i< tempindex; i++)
                {
                    array[i + firstindex] = temparr[i];
                }
                //int k = 0;
            }
            catch (System.Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}
