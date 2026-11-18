using System;
using System.Diagnostics;
using System.Text;

namespace Buoi01_DeQuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("   TỔNG HỢP BÀI TẬP CẤU TRÚC DỮ LIỆU & GIẢI THUẬT (CHƯƠNG 1, 2 & 3)");
                Console.WriteLine("");
                Console.WriteLine("1.CHƯƠNG 1 ");
                Console.WriteLine("2.CHƯƠNG 2 ");
                Console.WriteLine("3.CHƯƠNG 3");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("Mời bạn chọn chương (0, 1, 2, 3): ");

                string chonChuong = Console.ReadLine() ?? "";
                Console.WriteLine();

                switch (chonChuong)
                {
                    case "1":
                        MenuChuong1();
                        break;
                    case "2":
                        MenuChuong2();
                        break;
                    case "3":
                        MenuChuong3();
                        break;
                    case "0":
                        Console.WriteLine("Đã thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Chọn từ 0 - 3 ");
                        break;
                }
            }
        }

        static void MenuChuong1()
        {
            while (true)
            {
                Console.WriteLine(" CHƯƠNG 1  ");
                Console.WriteLine("");
                Console.WriteLine("1. Bài tập 1: Tìm số lớn nhất và nhỏ nhất trong mảng 1000 số");
                Console.WriteLine("2. Bài tập 2: Bài toán FizzBuzz (từ 1 đến 100)");
                Console.WriteLine("3. Bài tập 3: Đảo ngược chuỗi");
                Console.WriteLine("4. Bài tập 4: In mảng và sắp xếp mảng 1000 số tăng dần");
                Console.WriteLine("5. Bài tập 5: Tìm số Fibonacci thứ n");
                Console.WriteLine("0. Quay lại chọn Chương");
                Console.Write("Mời bạn chọn bài tập Chương 1 (0-5): ");

                string luaChon = Console.ReadLine() ?? "";
                Console.WriteLine();

                switch (luaChon)
                {
                    case "1": Chuong1_Bai1(); break;
                    case "2": Chuong1_Bai2(); break;
                    case "3": Chuong1_Bai3(); break;
                    case "4": Chuong1_Bai4(); break;
                    case "5": Chuong1_Bai5(); break;
                    case "0": return;
                    default: Console.WriteLine("Vui lòng chọn từ 0 đến 5!"); break;
                }
            }
        }

        static void MenuChuong2()
        {
            while (true)
            {
                Console.WriteLine("   CHƯƠNG 2 ");
                Console.WriteLine("");
                Console.WriteLine("3. Bài tập 3: Kiểm tra số nguyên tố ");
                Console.WriteLine("4. Bài tập 4: Liệt kê số hoàn hảo ");
                Console.WriteLine("5. Bài tập 5: Tìm số Fibonacci thứ n ");
                Console.WriteLine("6. Bài tập 6: Sắp xếp dãy số thực ");
                Console.WriteLine("0. Quay lại chọn Chương");
                Console.Write("Chọn bài tập Chương 2 (0, 3, 4, 5, 6): ");

                string luaChon = Console.ReadLine() ?? "";
                Console.WriteLine();

                switch (luaChon)
                {
                    case "3": Chuong2_Bai3(); break;
                    case "4": Chuong2_Bai4(); break;
                    case "5": Chuong2_Bai5(); break;
                    case "6": Chuong2_Bai6(); break;
                    case "0": return;
                    default: Console.WriteLine("Vui lòng chọn 3, 4, 5, 6 hoặc 0!"); break;
                }
            }
        }

        static void MenuChuong3()
        {
            while (true)
            {
                Console.WriteLine("   CHƯƠNG 3 ");
                Console.WriteLine("");
                Console.WriteLine("1. Bài tập 1: Tính S(n) = 1 + 2 + 3 + ... + (n - 1) + n");
                Console.WriteLine("2. Bài tập 2: Tính S(n) = 1 + 2^2 + 3^2 + ... + (n - 1)^2 + n^2");
                Console.WriteLine("3. Bài tập 3: Tính S(n) = 1 + 1/2 + 1/3 + ... + 1/(n - 1) + 1/n");
                Console.WriteLine("4. Bài tập 4: Tính S(x, n) = x^n");
                Console.WriteLine("5. Bài tập 5: Tìm ước số lẻ lớn nhất của số nguyên dương n");
                Console.WriteLine("6. Bài tập 6: Tìm ước chung lớn nhất của 2 số nguyên dương a, b (Euclid)");
                Console.WriteLine("7. Bài tập 7: Đếm số chữ số của số nguyên dương n");
                Console.WriteLine("8. Bài tập 8: Tính tổng căn lồng nhau S(n) = sqrt(1 + sqrt(2 + ... + sqrt(n)))");
                Console.WriteLine("0. Quay lại chọn Chương");
                Console.Write("Mời bạn chọn bài tập Chương 3 (0-8): ");

                string luaChon = Console.ReadLine() ?? "";
                Console.WriteLine();

                switch (luaChon)
                {
                    case "1": Chuong3_Bai1(); break;
                    case "2": Chuong3_Bai2(); break;
                    case "3": Chuong3_Bai3(); break;
                    case "4": Chuong3_Bai4(); break;
                    case "5": Chuong3_Bai5(); break;
                    case "6": Chuong3_Bai6(); break;
                    case "7": Chuong3_Bai7(); break;
                    case "8": Chuong3_Bai8(); break;
                    case "0": return;
                    default: Console.WriteLine("Vui lòng chọn từ 0 đến 8!"); break;
                }
            }
        }

        static void Chuong1_Bai1()
        {
            Console.WriteLine(" CHƯƠNG 1 - BÀI 1: TÌM SỐ LỚN NHẤT VÀ NHỎ NHẤT TRONG MẢNG 1000 SỐ ");
            int N = 1000;
            int[] mang = new int[N];
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                mang[i] = rand.Next(0, 1001);
            }

            int maxSo = mang[0];
            int minSo = mang[0];

            for (int i = 1; i < N; i++)
            {
                if (mang[i] > maxSo) maxSo = mang[i];
                if (mang[i] < minSo) minSo = mang[i];
            }

            Console.WriteLine("a. Số lớn nhất trong mảng là: " + maxSo);
            Console.WriteLine("b. Số nhỏ nhất trong mảng là: " + minSo);
        }

        static void Chuong1_Bai2()
        {
            Console.WriteLine(" CHƯƠNG 1 - BÀI 2: FIZZBUZZ (1 ĐẾN 100) ");
            for (int so = 1; so <= 100; so++)
            {
                if (so % 3 == 0 && so % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (so % 3 == 0) Console.WriteLine("Fizz");
                else if (so % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(so);
            }
        }

        static void Chuong1_Bai3()
        {
            Console.WriteLine(" CHƯƠNG 1 - BÀI 3: ĐẢO NGƯỢC CHUỖI ");
            Console.Write("Mời bạn nhập vào một chuỗi: ");
            string chuoiGoc = Console.ReadLine() ?? "";
            string chuoiDao = "";

            foreach (char kyTu in chuoiGoc)
            {
                chuoiDao = kyTu + chuoiDao;
            }

            Console.WriteLine("Chuỗi sau khi đảo ngược là: " + chuoiDao);
        }

        static void Chuong1_Bai4()
        {
            Console.WriteLine(" CHƯƠNG 1 - BÀI 4: IN MẢNG VÀ SẮP XẾP MẢNG 1000 SỐ TĂNG DẦN ");
            int N = 1000;
            int[] mang = new int[N];
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                mang[i] = rand.Next(0, 1001);
            }

            Console.WriteLine("a. Mảng ban đầu khi chưa sắp xếp:");
            Console.WriteLine(string.Join(", ", mang));

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (mang[j] < mang[i])
                    {
                        int tam = mang[i];
                        mang[i] = mang[j];
                        mang[j] = tam;
                    }
                }
            }

            Console.WriteLine("\nb. Mảng sau khi đã sắp xếp theo chiều tăng dần:");
            Console.WriteLine(string.Join(", ", mang));
        }

        static void Chuong1_Bai5()
        {
            Console.WriteLine(" CHƯƠNG 1 - BÀI 5: TÌM SỐ FIBONACCI THỨ N ");
            Console.Write("Mời bạn nhập vào số nguyên dương n: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương lớn hơn 0!");
                return;
            }

            if (n == 1)
            {
                Console.WriteLine("Số Fibonacci thứ 1 là: 0");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("Số Fibonacci thứ 2 là: 1");
                return;
            }

            long f0 = 0, f1 = 1, fn = 1;
            for (int i = 3; i <= n; i++)
            {
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
            }

            Console.WriteLine("Số thứ " + n + " trong dãy Fibonacci (0, 1, 1, 2, 3, 5, 8...) là: " + fn);
        }

        static void Chuong2_Bai3()
        {
            Console.WriteLine(" CHƯƠNG 2 - BÀI 3: KIỂM TRA SỐ NGUYÊN TỐ ");
            Console.Write("Nhập số nguyên dương n cần kiểm tra: ");
            long n;
            if (!long.TryParse(Console.ReadLine(), out n) || n <= 0) return;

            long b1 = 0, b2 = 0, b3 = 0;
            bool kq1 = NguyenTo_GT1(n, ref b1);
            bool kq2 = NguyenTo_GT2(n, ref b2);
            bool kq3 = NguyenTo_GT3_Fermat(n, 10, ref b3);

            Console.WriteLine("\nKết quả kiểm tra " + n + ": " + (kq2 ? "LÀ SỐ NGUYÊN TỐ" : "KHÔNG PHẢI SỐ NGUYÊN TỐ"));
            Console.WriteLine("- GT1 (Duyệt 2 -> n-1, O(n)):        Số bước = " + b1);
            Console.WriteLine("- GT2 (Duyệt 2 -> sqrt(n), O(√n)):   Số bước = " + b2);
            Console.WriteLine("- GT3 (Fermat, O(k log n)):          Số bước = " + b3);

            Console.WriteLine("\nBảng so sánh thời gian chạy (µs):");
            Console.WriteLine(string.Format("{0,-18} | {1,-18} | {2,-18} | {3,-18}", "Số nguyên tố n", "GT1: O(n) (µs)", "GT2: O(√n) (µs)", "GT3: Fermat (µs)"));
            Console.WriteLine(new string('-', 80));

            long[] ds = { 10007, 100003, 1000003, 10000019, 100000007 };
            foreach (long p in ds)
            {
                long c1 = 0, c2 = 0, c3 = 0;
                Stopwatch sw1 = Stopwatch.StartNew(); NguyenTo_GT1(p, ref c1); sw1.Stop();
                Stopwatch sw2 = Stopwatch.StartNew(); NguyenTo_GT2(p, ref c2); sw2.Stop();
                Stopwatch sw3 = Stopwatch.StartNew(); NguyenTo_GT3_Fermat(p, 10, ref c3); sw3.Stop();

                Console.WriteLine(string.Format("{0,-18} | {1,18:F2} | {2,18:F2} | {3,18:F2}",
                    p, sw1.Elapsed.TotalMilliseconds * 1000.0, sw2.Elapsed.TotalMilliseconds * 1000.0, sw3.Elapsed.TotalMilliseconds * 1000.0));
            }
        }

        static bool NguyenTo_GT1(long n, ref long soBuoc)
        {
            soBuoc = 0;
            if (n < 2) return false;
            for (long i = 2; i <= n - 1; i++)
            {
                soBuoc++;
                if (n % i == 0) return false;
            }
            return true;
        }

        static bool NguyenTo_GT2(long n, ref long soBuoc)
        {
            soBuoc = 0;
            if (n < 2) return false;
            long can = (long)Math.Sqrt(n);
            for (long i = 2; i <= can; i++)
            {
                soBuoc++;
                if (n % i == 0) return false;
            }
            return true;
        }

        static bool NguyenTo_GT3_Fermat(long n, int k, ref long soBuoc)
        {
            soBuoc = 0;
            if (n < 2) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0) return false;
            Random rand = new Random(42);
            for (int i = 0; i < k; i++)
            {
                long a = 2 + (long)(rand.NextDouble() * (n - 3));
                if (LuyThuaModulo(a, n - 1, n, ref soBuoc) != 1) return false;
            }
            return true;
        }

        static long LuyThuaModulo(long coSo, long soMu, long mod, ref long soBuoc)
        {
            long kq = 1;
            coSo %= mod;
            while (soMu > 0)
            {
                soBuoc++;
                if ((soMu & 1) == 1) kq = (kq * coSo) % mod;
                coSo = (coSo * coSo) % mod;
                soMu >>= 1;
            }
            return kq;
        }

        static void Chuong2_Bai4()
        {
            Console.WriteLine(" CHƯƠNG 2 - BÀI 4: LIỆT KÊ SỐ HOÀN HẢO NHỎ HƠN N ");
            Console.WriteLine("Các số hoàn hảo nhỏ hơn 10000 là: ");
            for (int x = 2; x < 10000; x++)
            {
                if (LaSoHoanHao_CaiTien(x)) Console.Write(x + "  ");
            }
            Console.WriteLine("\n\nBảng so sánh thời gian chạy (ms):");
            Console.WriteLine(string.Format("{0,-15} | {1,-20} | {2,-22}", "Kích thước N", "GT1: O(N^2) (ms)", "GT2: O(N*sqrt(N)) (ms)"));
            Console.WriteLine(new string('-', 63));

            int[] cacN = { 2000, 5000, 10000, 20000 };
            foreach (int N in cacN)
            {
                Stopwatch sw1 = Stopwatch.StartNew();
                for (int x = 2; x < N; x++) LaSoHoanHao_CoBan(x);
                sw1.Stop();

                Stopwatch sw2 = Stopwatch.StartNew();
                for (int x = 2; x < N; x++) LaSoHoanHao_CaiTien(x);
                sw2.Stop();

                Console.WriteLine(string.Format("{0,-15} | {1,20:F2} | {2,22:F2}", N, sw1.Elapsed.TotalMilliseconds, sw2.Elapsed.TotalMilliseconds));
            }
        }

        static bool LaSoHoanHao_CoBan(int x)
        {
            if (x < 2) return false;
            int tong = 1;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) tong += i;
            }
            return tong == x;
        }

        static bool LaSoHoanHao_CaiTien(int x)
        {
            if (x < 2) return false;
            int tong = 1;
            int can = (int)Math.Sqrt(x);
            for (int i = 2; i <= can; i++)
            {
                if (x % i == 0)
                {
                    tong += i;
                    if (i * i != x) tong += x / i;
                }
            }
            return tong == x;
        }

        static void Chuong2_Bai5()
        {
            Console.WriteLine(" CHƯƠNG 2 - BÀI 5: TÌM SỐ FIBONACCI THỨ N ");
            Console.WriteLine(string.Format("{0,-6} | {1,-18} | {2,-18} | {3,-18} | {4,-18}",
                "n", "GT1: Đệ quy (µs)", "GT2: Vòng lặp (µs)", "GT3: Đệ quy nhớ (µs)", "GT4: Ma trận (µs)"));
            Console.WriteLine(new string('-', 88));

            int[] cacN = { 10, 20, 30, 35, 40 };
            foreach (int n in cacN)
            {
                Stopwatch sw1 = Stopwatch.StartNew(); Fib_DeQuy(n); sw1.Stop();
                Stopwatch sw2 = Stopwatch.StartNew(); Fib_Lap(n); sw2.Stop();
                Stopwatch sw3 = Stopwatch.StartNew();
                long[] memo = new long[n + 1];
                for (int i = 0; i <= n; i++) memo[i] = -1;
                Fib_DeQuyCoNho(n, memo);
                sw3.Stop();
                Stopwatch sw4 = Stopwatch.StartNew(); Fib_MaTran(n); sw4.Stop();

                Console.WriteLine(string.Format("{0,-6} | {1,18:F2} | {2,18:F2} | {3,18:F2} | {4,18:F2}",
                    n,
                    sw1.Elapsed.TotalMilliseconds * 1000.0,
                    sw2.Elapsed.TotalMilliseconds * 1000.0,
                    sw3.Elapsed.TotalMilliseconds * 1000.0,
                    sw4.Elapsed.TotalMilliseconds * 1000.0));
            }
        }

        static long Fib_DeQuy(int n)
        {
            if (n <= 1) return n;
            return Fib_DeQuy(n - 1) + Fib_DeQuy(n - 2);
        }

        static long Fib_Lap(int n)
        {
            if (n <= 1) return n;
            long f0 = 0, f1 = 1, fn = 1;
            for (int i = 2; i <= n; i++)
            {
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
            }
            return fn;
        }

        static long Fib_DeQuyCoNho(int n, long[] memo)
        {
            if (n <= 1) return n;
            if (memo[n] != -1) return memo[n];
            memo[n] = Fib_DeQuyCoNho(n - 1, memo) + Fib_DeQuyCoNho(n - 2, memo);
            return memo[n];
        }

        static long Fib_MaTran(int n)
        {
            if (n <= 1) return n;
            long[,] ketQua = { { 1, 0 }, { 0, 1 } };
            long[,] coSo = { { 1, 1 }, { 1, 0 } };
            int mu = n - 1;
            while (mu > 0)
            {
                if ((mu & 1) == 1) ketQua = NhanMaTran2x2(ketQua, coSo);
                coSo = NhanMaTran2x2(coSo, coSo);
                mu >>= 1;
            }
            return ketQua[0, 0];
        }

        static long[,] NhanMaTran2x2(long[,] A, long[,] B)
        {
            return new long[,]
            {
                { A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0], A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1] },
                { A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0], A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1] }
            };
        }

        static void Chuong2_Bai6()
        {
            Console.WriteLine(" CHƯƠNG 2 - BÀI 6: SẮP XẾP DÃY SỐ THỰC TĂNG DẦN (Đơn vị: ms) ");
            Console.WriteLine(string.Format("{0,-12} | {1,-13} | {2,-14} | {3,-14} | {4,-12} | {5,-12}",
                "Số phần tử", "Bubble Sort", "Selection Sort", "Insertion Sort", "Quick Sort", "Merge Sort"));
            Console.WriteLine(new string('-', 88));

            int[] kichThuoc = { 1000, 3000, 5000, 10000 };
            Random rand = new Random(42);

            foreach (int n in kichThuoc)
            {
                double[] goc = new double[n];
                for (int i = 0; i < n; i++) goc[i] = rand.NextDouble() * 10000.0;

                double[] a1 = (double[])goc.Clone();
                double[] a2 = (double[])goc.Clone();
                double[] a3 = (double[])goc.Clone();
                double[] a4 = (double[])goc.Clone();
                double[] a5 = (double[])goc.Clone();

                Stopwatch sw = Stopwatch.StartNew(); BubbleSort(a1); double t1 = sw.Elapsed.TotalMilliseconds;
                sw.Restart(); SelectionSort(a2); double t2 = sw.Elapsed.TotalMilliseconds;
                sw.Restart(); InsertionSort(a3); double t3 = sw.Elapsed.TotalMilliseconds;
                sw.Restart(); QuickSort(a4, 0, n - 1); double t4 = sw.Elapsed.TotalMilliseconds;
                sw.Restart(); MergeSort(a5, 0, n - 1); double t5 = sw.Elapsed.TotalMilliseconds;

                Console.WriteLine(string.Format("{0,-12} | {1,13:F2} | {2,14:F2} | {3,14:F2} | {4,12:F2} | {5,12:F2}",
                    n, t1, t2, t3, t4, t5));
            }
        }

        static void BubbleSort(double[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool doi = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        double tam = a[j]; a[j] = a[j + 1]; a[j + 1] = tam;
                        doi = true;
                    }
                }
                if (!doi) break;
            }
        }

        static void SelectionSort(double[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[minIdx]) minIdx = j;
                }
                if (minIdx != i)
                {
                    double tam = a[i]; a[i] = a[minIdx]; a[minIdx] = tam;
                }
            }
        }

        static void InsertionSort(double[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; i++)
            {
                double key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }

        static void QuickSort(double[] a, int left, int right)
        {
            int i = left, j = right;
            double chot = a[(left + right) / 2];
            while (i <= j)
            {
                while (a[i] < chot) i++;
                while (a[j] > chot) j--;
                if (i <= j)
                {
                    double tam = a[i]; a[i] = a[j]; a[j] = tam;
                    i++; j--;
                }
            }
            if (left < j) QuickSort(a, left, j);
            if (i < right) QuickSort(a, i, right);
        }

        static void MergeSort(double[] a, int left, int right)
        {
            if (left >= right) return;
            int mid = left + (right - left) / 2;
            MergeSort(a, left, mid);
            MergeSort(a, mid + 1, right);

            double[] tam = new double[right - left + 1];
            int i = left, j = mid + 1, k = 0;
            while (i <= mid && j <= right)
            {
                if (a[i] <= a[j]) tam[k++] = a[i++];
                else tam[k++] = a[j++];
            }
            while (i <= mid) tam[k++] = a[i++];
            while (j <= right) tam[k++] = a[j++];
            for (int p = 0; p < tam.Length; p++) a[left + p] = tam[p];
        }

        static void Chuong3_Bai1()
        {
            Console.WriteLine(" CHƯƠNG 3 - BÀI 1: TÍNH S(n) = 1 + 2 + 3 + ... + (n - 1) + n ");
            Console.Write("Nhập số nguyên dương n: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương n >= 1!");
                return;
            }

            long ketQua = DeQuy_TongTu1DenN(n);
            Console.WriteLine("Kết quả S(" + n + ") = " + ketQua);
        }

        static long DeQuy_TongTu1DenN(int n)
        {
            if (n == 1) return 1;
            return DeQuy_TongTu1DenN(n - 1) + n;
        }

        static void Chuong3_Bai2()
        {
            Console.WriteLine(" CHƯƠNG 3 - BÀI 2: TÍNH S(n) = 1 + 2^2 + 3^2 + ... + (n - 1)^2 + n^2 ");
            Console.Write("Nhập số nguyên dương n: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương n >= 1!");
                return;
            }

            long ketQua = DeQuy_TongBinhPhuong(n);
            Console.WriteLine("Kết quả S(" + n + ") = " + ketQua);
        }

        static long DeQuy_TongBinhPhuong(int n)
        {
            if (n == 1) return 1;
            return DeQuy_TongBinhPhuong(n - 1) + (long)n * n;
        }

        static void Chuong3_Bai3()
        {
            Console.WriteLine(" CHƯƠNG 3 - BÀI 3: TÍNH S(n) = 1 + 1/2 + 1/3 + ... + 1/(n - 1) + 1/n ");
            Console.Write("Nhập số nguyên dương n: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương n >= 1!");
                return;
            }

            double ketQua = DeQuy_TongNghichDao(n);
            Console.WriteLine("Kết quả S(" + n + ") = " + ketQua);
        }

        static double DeQuy_TongNghichDao(int n)
        {
            if (n == 1) return 1.0;
            return DeQuy_TongNghichDao(n - 1) + 1.0 / n;
        }

        static void Chuong3_Bai4()
        {
            Console.WriteLine(" CHƯƠNG 3 - BÀI 4: TÍNH S(x, n) = x^n ");
            Console.Write("Nhập cơ số thực x: ");
            double x;
            if (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Cơ số x không hợp lệ!");
                return;
            }

            Console.Write("Nhập số mũ nguyên n (có thể âm, bằng 0 hoặc dương): ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Số mũ n không hợp lệ!");
                return;
            }

            double ketQua = TinhS_LuyThua(x, n);
            Console.WriteLine("Kết quả S(" + x + ", " + n + ") = " + ketQua);
        }

        static double LuyThua(double x, int n)
        {
            if (n == 0) return 1.0;
            return LuyThua(x, n - 1) * x;
        }

        static double TinhS_LuyThua(double x, int n)
        {
            if (n < 0) return 1.0 / LuyThua(x, -n);
            return LuyThua(x, n);
        }

        static void Chuong3_Bai5()
        {
            Console.WriteLine(" CHƯƠNG 3 - BÀI 5: TÌM ƯỚC SỐ LẺ LỚN NHẤT CỦA SỐ NGUYÊN DƯƠNG n ");
            Console.Write("Nhập số nguyên dương n (ví dụ n = 100): ");
            long n;
            if (!long.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương n > 0!");
                return;
            }

            long ketQua = UocLeMax(n);
            Console.WriteLine("Ước số lẻ lớn nhất của " + n + " là: " + ketQua);
        }

        static long UocLeMax(long n)
        {
            if (n % 2 == 1) return n;
            return UocLeMax(n / 2);
        }

        static void Chuong3_Bai6()
        {
            Console.WriteLine(" CHƯƠNG 3 - BÀI 6: TÌM ƯỚC CHUNG LỚN NHẤT CỦA 2 SỐ NGUYÊN DƯƠNG a, b ");
            Console.Write("Nhập số nguyên dương a: ");
            long a;
            if (!long.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Vui lòng nhập a > 0!");
                return;
            }

            Console.Write("Nhập số nguyên dương b: ");
            long b;
            if (!long.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Vui lòng nhập b > 0!");
                return;
            }

            long ketQua = UCLN(a, b);
            Console.WriteLine("Ước chung lớn nhất UCLN(" + a + ", " + b + ") = " + ketQua);
        }

        static long UCLN(long a, long b)
        {
            if (a % b == 0) return b;
            return UCLN(b, a % b);
        }

        static void Chuong3_Bai7()
        {
            Console.WriteLine(" CHƯƠNG 3 - BÀI 7: ĐẾM SỐ CHỮ SỐ CỦA SỐ NGUYÊN DƯƠNG n ");
            Console.Write("Nhập số nguyên dương n: ");
            long n;
            if (!long.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương n > 0!");
                return;
            }

            int ketQua = SoChuSo(n);
            Console.WriteLine("Số chữ số của " + n + " là: " + ketQua);
        }

        static int SoChuSo(long n)
        {
            if (n == 0) return 0;
            return SoChuSo(n / 10) + 1;
        }

        static void Chuong3_Bai8()
        {
            Console.WriteLine(" CHƯƠNG 3 - BÀI 8: TÍNH S(n) = sqrt(1 + sqrt(2 + ... + sqrt(n))) ");
            Console.Write("Nhập số nguyên dương n: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương n >= 1!");
                return;
            }

            float ketQua = TinhS_TongCan(n);
            Console.WriteLine("Kết quả S(" + n + ") = " + ketQua);
        }

        static float Can(int i, int n)
        {
            if (i == n) return (float)Math.Sqrt(n);
            return (float)Math.Sqrt(i + Can(i + 1, n));
        }

        static float TinhS_TongCan(int n)
        {
            return Can(1, n);
        }
    }
}