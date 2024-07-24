//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Buoi3_PTTKTT
//{
//    class Cau1_DeQui
//    {
//        static int SumRecursively(int n)
//        {
//            if (n <= 0)
//            {
//                return 0;
//            }
//            return n + SumRecursively(n - 1);
//        }

//        static void SumArray()
//        {
//            Console.WriteLine("Nhap so luong phan tu trong mang:");
//            int n = int.Parse(Console.ReadLine());
//            if (n <= 0)
//            {
//                Console.WriteLine("So luong phan tu phai lon hon 0.");
//                return;
//            }
//            int sum = SumRecursively(n);

//            Console.WriteLine("Tong cac so tu 1 đen {0} la: {1}", n, sum);
//            Console.ReadKey();
//        }

//        static void Main()
//        {
//            SumArray();
//        }
//    }
//}
