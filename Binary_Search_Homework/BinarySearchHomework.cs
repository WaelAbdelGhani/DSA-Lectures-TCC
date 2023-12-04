using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            if (end < start)
                return -1;

            int left = (start + (end - start) / 3);

            int right = (end - (end - start) / 3);

            if (arr[left] == key)
                return left;

            if (arr[right] == key)
                return right;

            if (arr[left] > key)
                return TernarySearch(arr, key, start, left - 1);

            if (arr[right] < key)
                return TernarySearch(arr, key, right + 1, end);

            return TernarySearch(arr, key, left + 1, right - 1);
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance

            if (is_first == true)
            {
                int index = -1;
                while (start <= end)
                {
                    int middle = ((end + start) / 2);
                    if (arr[middle] == key)
                    {
                        index = middle;
                        end = middle - 1;
                        continue;
                    }
                    if (arr[middle] > key)
                    {
                        end = middle - 1;
                        continue;
                    }
                    start = middle + 1;
                }
                return index;
            }
            else
            {
                int index = -1;
                while (start <= end)
                {
                    int middle = ((start + end) / 2);
                    if (arr[middle] == key)
                    {
                        index = middle;
                        start = middle + 1;
                        continue;
                    }
                    if (arr[middle] > key)
                    {
                        end = middle - 1;
                        continue;
                    }
                    start = middle + 1;
                }
                return index;
            }
        }
        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            int total = 0;

            int firsttime = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);

            if (firsttime == -1)
                return total;

            int lastitem = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);

            total = ((lastitem- firsttime) + 1);

            return total;
        }
    }
}
