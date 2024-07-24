using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_PTTKTT
{
    class Cau3_TKNP_KhongDeQui
    {
        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid; // Đã tìm thấy phần tử
                }
                else if (array[mid] < target)
                {
                    left = mid + 1; // Tìm ở nửa bên phải
                }
                else
                {
                    right = mid - 1; // Tìm ở nửa bên trái
                }
            }

            return -1; // Không tìm thấy phần tử
        }
        static void Main()
        {
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            Console.WriteLine("Nhap so can tim:");
            int target = int.Parse(Console.ReadLine());

            int index = BinarySearch(sortedArray, target);

            if (index != -1)
            {
                Console.WriteLine("So {0} duoc tim thay tai chi so {1}.", target, index);
            }
            else
            {
                Console.WriteLine("So {0} khong co trong mang.", target);
            }

            Console.ReadKey();
        }
    }
}
