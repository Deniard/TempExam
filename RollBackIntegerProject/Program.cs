using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace RollBackIntegerProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Task19();


            Console.ReadKey();
        }

        private static void Task19()
        {
            string way = @"C:\Users\user\Downloads\Tinder Egor";

            DirectoryInfo dir = new DirectoryInfo(way);
            if (dir.Exists)
            {
                var files = dir.GetFiles("*.JPG");
                foreach (FileInfo file in files)
                {
                    Console.WriteLine("Имя файла: {0}", file.Name);
                    Console.WriteLine("Время создания: {0}", file.CreationTime);
                    Console.WriteLine("Размер: {0}\n", file.Length);
                }
            }

            
        }

        private static void Task13()
        {
            int n = 10;
            ArrayList arr = new ArrayList(n);
            for (int i = 0; i < n; i++)
            {
                arr.Add(i % 9 * Math.Pow(-1, i));
            }
            Console.WriteLine(string.Join(" ", arr.ToArray()));

            ArrayList t1 = new ArrayList();
            ArrayList t2 = new ArrayList();
            foreach (Object obj in arr)
            {
                if(Convert.ToDouble(obj) < 0)
                {
                    t1.Add(obj);
                } else
                {
                    t2.Add(obj);
                }
            }

            ArrayList ans = new ArrayList();
            ans.AddRange(t1);
            t2.Reverse();
            ans.AddRange(t2);
            Console.WriteLine(string.Join(" ", ans.ToArray()));

        }

        private static void Task10()
        {
            int n = 10;
            ArrayList arr = new ArrayList(n);
            for (int i = 0; i < n; i++)
            {
                arr.Add(i % 9);
            }
            Console.WriteLine(string.Join(" ", arr.ToArray()));
            ArrayList arrAns = new ArrayList(n * 2);
            arr.Reverse();
            arrAns.AddRange(arr);
            arr.Reverse();
            arrAns.AddRange(arr);
            Console.WriteLine(string.Join(" ", arrAns.ToArray()));
        }

        private static void Task9()
        {
            int n = 4;
            ArrayList arr = new ArrayList(n * 3);
            for (int i = 0; i < n * 3; i++)
            {
                arr.Add(i % 6);
            }

            var arr1 = arr.GetRange(n * 2, n);
            var arr2 = arr.GetRange(0, n * 2);

            Console.WriteLine(string.Join(" ", arr.ToArray()));
            Console.WriteLine(string.Join(" ", arr1.ToArray()));
            Console.WriteLine(string.Join(" ", arr2.ToArray()));

            bool flag = true;

            foreach (Object obj in arr1)
            {
                if (!arr2.Contains(obj))
                {
                    flag = false;
                    break;
                }
            }

            Console.WriteLine(flag);
        }

        private static void Task8()
        {
            int n = 7;
            LinkedList<Double> list = new LinkedList<double>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddFirst(5);
            list.AddFirst(7);
            list.AddFirst(6);

            if (list.Distinct().Count() != n)
            {
                Console.WriteLine("est odnakovi");
            }
            else
            {
                Console.WriteLine("netu");
            }
        }

        private static void Task6()
        {
            int n = 4;
            ArrayList arr = new ArrayList(n);
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);


            Double sum = 0;

            for (int i = 0; i < n / 2; i++)
            {
                sum = sum + 2 * Convert.ToDouble(arr[i]) * Convert.ToDouble(arr[n - 1 - i]);
            }
            if (n % 2 != 0)
            {
                sum += Convert.ToDouble(arr[n / 2]) * Convert.ToDouble(arr[n / 2]);
            }

            Console.WriteLine(sum);
        }

        private static void TestGenerics()
        {
            int[,] m = new int[3, 4]
            {
                {1, 2, 3, 4 },
                {1, 2, 3, 4 },
                {1, 2, 3, 4 }
            };

            Console.WriteLine(sumMatrix(m, new Int32Adder()));
        }

        interface IAdder<T>
        {
            T Zero { get; }

            T Add(T a, T b);
        }

        class Int32Adder : IAdder<Int32>
        {
            public int Zero { get { return 0; } }

            public int Add(int a, int b) { return a + b; }
        }

        private static T sumMatrix <T>(T[,] matrix, IAdder<T> adder){
            T sum = adder.Zero;

            foreach(T i in matrix){
                sum = adder.Add(sum, i);
            }

            return sum;
        }

        private static void TestRollBackInteger()
        {
            RollBackInteger rbi = new RollBackInteger(45);
            Console.WriteLine(rbi.Value);
            rbi.Value = 156;
            Console.WriteLine(rbi.Value);

            rbi.RollBack();
            Console.WriteLine(rbi.Value);

            rbi.RollBack();
            Console.WriteLine(rbi.Value);

            rbi.RollBack();
            Console.WriteLine(rbi.Value);
        }
    }
}
