//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Buoi3_PTTKTT
//{
//    class Cau2
//    {
//        static void Main(string[] args)
//        {
//            QuickSortArray();
//            Console.InputEncoding = UnicodeEncoding.Unicode;
//            Console.OutputEncoding = UnicodeEncoding.Unicode;
//        }

//        static void QuickSortArray()
//        {
//            Console.WriteLine("Nhap so luong phan tu trong mang:");
//            int n = int.Parse(Console.ReadLine());
//            int[] array = new int[n];

//            Console.WriteLine("Nhap cac phan tu cua mang:");
//            for (int i = 0; i < n; i++)
//            {
//                array[i] = int.Parse(Console.ReadLine());
//            }

//            QuickSort(array, 0, array.Length - 1);

//            Console.WriteLine("Mang sau khi sap xep QuickSort:");
//            foreach (int num in array)
//            {
//                Console.Write(num + " ");
//            }
//            Console.WriteLine();
//            Console.ReadKey();

//        }

//        static void QuickSort(int[] array, int low, int high)
//        {
//            if (low < high)
//            {
//                int pi = Partition(array, low, high);

//                QuickSort(array, low, pi - 1);
//                QuickSort(array, pi + 1, high);
//            }
//        }

//        static int Partition(int[] array, int low, int high)
//        {
//            int pivot = array[high];
//            int i = (low - 1);

//            for (int j = low; j < high; j++)
//            {
//                if (array[j] < pivot)
//                {
//                    i++;

//                    int temp = array[i];
//                    array[i] = array[j];
//                    array[j] = temp;
//                }
//            }

//            int temp1 = array[i + 1];
//            array[i + 1] = array[high];
//            array[high] = temp1;

//            return i + 1;
//        }
//    }
//}
