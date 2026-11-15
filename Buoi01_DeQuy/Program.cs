using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // =====================================================================
        // PHẦN 1: MỤC 1.4.2 - BÀI TẬP ÔN TẬP CƠ BẢN (5 BÀI)
        // =====================================================================
        Console.WriteLine("================ MỤC 1.4.2 ================");

        Console.WriteLine("\n--- Mục 1.4.2 - Bài 1: Tìm Max, Min mảng 1000 số ---");
        Muc1_4_2_Bai1();

        Console.WriteLine("\n--- Mục 1.4.2 - Bài 2: FizzBuzz (1 -> 100) ---");
        Muc1_4_2_Bai2();

        Console.WriteLine("\n--- Mục 1.4.2 - Bài 3: Đảo ngược chuỗi ---");
        Muc1_4_2_Bai3();

        Console.WriteLine("\n--- Mục 1.4.2 - Bài 4: In và sắp xếp mảng 1000 số ---");
        Muc1_4_2_Bai4();

        Console.WriteLine("\n--- Mục 1.4.2 - Bài 5: Tìm số Fibonacci thứ n ---");
        Muc1_4_2_Bai5();

        // =====================================================================
        // PHẦN 2: MỤC 2.5.2 - ĐỘ PHỨC TẠP GIẢI THUẬT & THỰC NGHIỆM (6 BÀI)
        // (Bài 1 và Bài 2 là bài tập lý thuyết, xem trong phần ghi chú bên dưới)
        // =====================================================================
        Console.WriteLine("\n================ MỤC 2.5.2 ================");

        Console.WriteLine("\n--- Mục 2.5.2 - Bài 3: Kiểm tra số nguyên tố ---");
        Muc2_5_2_Bai3();

        Console.WriteLine("\n--- Mục 2.5.2 - Bài 4: Liệt kê số hoàn hảo < N ---");
        Muc2_5_2_Bai4();

        Console.WriteLine("\n--- Mục 2.5.2 - Bài 5: So sánh Fibonacci Đệ quy & Lặp ---");
        Muc2_5_2_Bai5();

        Console.WriteLine("\n--- Mục 2.5.2 - Bài 6: So sánh Bubble Sort & Quick Sort ---");
        Muc2_5_2_Bai6();

        // =====================================================================
        // PHẦN 3: MỤC 3.7.2 - GIẢI THUẬT ĐỆ QUY (8 BÀI)
        // =====================================================================
        Console.WriteLine("\n================ MỤC 3.7.2 ================");

        Console.WriteLine("\n--- Mục 3.7.2 - Bài 1: S(n) = 1 + 2 + ... + n ---");
        Muc3_7_2_Bai1();

        Console.WriteLine("\n--- Mục 3.7.2 - Bài 2: S(n) = 1^2 + 2^2 + ... + n^2 ---");
        Muc3_7_2_Bai2();

        Console.WriteLine("\n--- Mục 3.7.2 - Bài 3: S(n) = 1 + 1/2 + ... + 1/n ---");
        Muc3_7_2_Bai3();

        Console.WriteLine("\n--- Mục 3.7.2 - Bài 4: S(x, n) = x^n ---");
        Muc3_7_2_Bai4();

        Console.WriteLine("\n--- Mục 3.7.2 - Bài 5: Ước số lẻ lớn nhất ---");
        Muc3_7_2_Bai5();

        Console.WriteLine("\n--- Mục 3.7.2 - Bài 6: Ước chung lớn nhất (Euclid) ---");
        Muc3_7_2_Bai6();

        Console.WriteLine("\n--- Mục 3.7.2 - Bài 7: Đếm số chữ số của n ---");
        Muc3_7_2_Bai7();

        Console.WriteLine("\n--- Mục 3.7.2 - Bài 8: Tổng căn bậc hai lồng nhau ---");
        Muc3_7_2_Bai8();
    }

    #region PHẦN 1: MỤC 1.4.2

    // Mục 1.4.2 - Bài 1: Nhập ngẫu nhiên 1000 số tự nhiên vào mảng, tìm số lớn nhất và nhỏ nhất
    static void Muc1_4_2_Bai1()
    {
        Random rd = new Random();
        int[] a = new int[1000];
        for (int i = 0; i < a.Length; i++)
            a[i] = rd.Next(0, 10000);

        int max = a[0], min = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max) max = a[i];
            if (a[i] < min) min = a[i];
        }

        Console.WriteLine($"Số lớn nhất: {max}");
        Console.WriteLine($"Số nhỏ nhất: {min}");
    }

    // Mục 1.4.2 - Bài 2: Bài toán FizzBuzz từ 1 đến 100
    static void Muc1_4_2_Bai2()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 15 == 0) Console.Write("FizzBuzz ");
            else if (i % 3 == 0) Console.Write("Fizz ");
            else if (i % 5 == 0) Console.Write("Buzz ");
            else Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // Mục 1.4.2 - Bài 3: Đảo ngược chuỗi nhập từ bàn phím
    static void Muc1_4_2_Bai3()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine() ?? "";
        string dao = "";
        for (int i = s.Length - 1; i >= 0; i--)
            dao += s[i];

        Console.WriteLine($"Chuỗi đảo ngược: {dao}");
    }

    // Mục 1.4.2 - Bài 4: Nhập ngẫu nhiên 1000 số tự nhiên, in mảng, sắp xếp tăng dần và in lại
    static void Muc1_4_2_Bai4()
    {
        Random rd = new Random();
        int[] a = new int[1000];
        for (int i = 0; i < a.Length; i++)
            a[i] = rd.Next(0, 10000);

        Console.WriteLine("Mảng ban đầu:");
        Console.WriteLine(string.Join(" ", a));

        Array.Sort(a);
        Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
        Console.WriteLine(string.Join(" ", a));
    }

    // Mục 1.4.2 - Bài 5: Tìm số Fibonacci thứ n (F0 = 0, F1 = 1)
    static void Muc1_4_2_Bai5()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        if (n == 0) { Console.WriteLine("F(0) = 0"); return; }
        if (n == 1) { Console.WriteLine("F(1) = 1"); return; }

        long f0 = 0, f1 = 1, fn = 0;
        for (int i = 2; i <= n; i++)
        {
            fn = f0 + f1;
            f0 = f1;
            f1 = fn;
        }
        Console.WriteLine($"F({n}) = {fn}");
    }

    #endregion

    #region PHẦN 2: MỤC 2.5.2

    /*
     * Mục 2.5.2 - Bài 1 (Lý thuyết): Tháp Hà Nội
     * - Hệ thức truy hồi: T(n) = 2T(n - 1) + 1, cơ sở T(1) = 1
     * - Giải lặp: T(n) = 2^n - 1
     * - Độ phức tạp: O(2^n)
     *
     * Mục 2.5.2 - Bài 2 (Lý thuyết): Tìm kiếm nhị phân (Binary Search)
     * - Hệ thức truy hồi: T(n) = T(n / 2) + 1, cơ sở T(1) = 1
     * - Giải lặp: T(n) = log2(n) + 1
     * - Độ phức tạp: O(log n)
     */

    // Mục 2.5.2 - Bài 3: Kiểm tra số nguyên tố (2 giải thuật + đo thời gian thực nghiệm)
    static bool LaNguyenTo_CoBan(long n) // O(n)
    {
        if (n < 2) return false;
        for (long i = 2; i <= n - 1; i++)
            if (n % i == 0) return false;
        return true;
    }

    static bool LaNguyenTo_CaiTien(long n) // O(√n)
    {
        if (n < 2) return false;
        for (long i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    static void Muc2_5_2_Bai3()
    {
        long n = 100000007;
        Stopwatch sw = new Stopwatch();

        sw.Start();
        bool kq1 = LaNguyenTo_CoBan(n);
        sw.Stop();
        Console.WriteLine($"Cơ bản (2 -> n-1) [O(n)] : {kq1} | Thời gian: {sw.Elapsed.TotalMilliseconds:F6} ms");

        sw.Restart();
        bool kq2 = LaNguyenTo_CaiTien(n);
        sw.Stop();
        Console.WriteLine($"Cải tiến (2 -> √n) [O(√n)]: {kq2} | Thời gian: {sw.Elapsed.TotalMilliseconds:F6} ms");
    }

    // Mục 2.5.2 - Bài 4: Liệt kê các số hoàn hảo nhỏ hơn N (2 giải thuật + đo thời gian)
    static bool LaHoanHao_CoBan(int x) // O(x) -> tổng thể O(N^2)
    {
        if (x < 2) return false;
        int tong = 0;
        for (int i = 1; i < x; i++)
            if (x % i == 0) tong += i;
        return tong == x;
    }

    static bool LaHoanHao_CaiTien(int x) // O(√x) -> tổng thể O(N√N)
    {
        if (x < 2) return false;
        int tong = 1;
        for (int i = 2; i * i <= x; i++)
        {
            if (x % i == 0)
            {
                tong += i;
                if (i != x / i) tong += x / i;
            }
        }
        return tong == x;
    }

    static void Muc2_5_2_Bai4()
    {
        int N = 10000;
        Stopwatch sw = new Stopwatch();

        sw.Start();
        Console.Write("Cơ bản [O(N^2)]   : ");
        for (int i = 1; i < N; i++)
            if (LaHoanHao_CoBan(i)) Console.Write(i + " ");
        sw.Stop();
        Console.WriteLine($"| Thời gian: {sw.Elapsed.TotalMilliseconds:F6} ms");

        sw.Restart();
        Console.Write("Cải tiến [O(N√N)] : ");
        for (int i = 1; i < N; i++)
            if (LaHoanHao_CaiTien(i)) Console.Write(i + " ");
        sw.Stop();
        Console.WriteLine($"| Thời gian: {sw.Elapsed.TotalMilliseconds:F6} ms");
    }

    // Mục 2.5.2 - Bài 5: Tìm số Fibonacci thứ n (Đệ quy trực tiếp vs Lặp)
    static long Fib_DeQuy(int n) // O(2^n)
    {
        if (n <= 1) return n;
        return Fib_DeQuy(n - 1) + Fib_DeQuy(n - 2);
    }

    static long Fib_Lap(int n) // O(n)
    {
        if (n <= 1) return n;
        long a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }

    static void Muc2_5_2_Bai5()
    {
        int n = 40;
        Stopwatch sw = new Stopwatch();

        sw.Start();
        long kq1 = Fib_DeQuy(n);
        sw.Stop();
        Console.WriteLine($"Đệ quy [O(2^n)] F({n}) = {kq1} | Thời gian: {sw.Elapsed.TotalMilliseconds:F6} ms");

        sw.Restart();
        long kq2 = Fib_Lap(n);
        sw.Stop();
        Console.WriteLine($"Lặp    [O(n)]   F({n}) = {kq2} | Thời gian: {sw.Elapsed.TotalMilliseconds:F6} ms");
    }

    // Mục 2.5.2 - Bài 6: Sắp xếp dãy n số thực tăng dần (Bubble Sort vs Quick Sort)
    static void BubbleSort(double[] a) // O(n^2)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    (a[j], a[j + 1]) = (a[j + 1], a[j]);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }

    static void QuickSort(double[] a, int left, int right) // Trung bình O(n log n)
    {
        int i = left, j = right;
        double pivot = a[(left + right) / 2];
        while (i <= j)
        {
            while (a[i] < pivot) i++;
            while (a[j] > pivot) j--;
            if (i <= j)
            {
                (a[i], a[j]) = (a[j], a[i]);
                i++;
                j--;
            }
        }
        if (left < j) QuickSort(a, left, j);
        if (i < right) QuickSort(a, i, right);
    }

    static void Muc2_5_2_Bai6()
    {
        int n = 10000;
        Random rd = new Random();
        double[] arr1 = new double[n];
        for (int i = 0; i < n; i++)
            arr1[i] = Math.Round(rd.NextDouble() * 1000, 2);

        double[] arr2 = (double[])arr1.Clone();
        Stopwatch sw = new Stopwatch();

        sw.Start();
        BubbleSort(arr1);
        sw.Stop();
        Console.WriteLine($"Bubble Sort [O(n^2)]     (n = {n}): {sw.Elapsed.TotalMilliseconds:F6} ms");

        sw.Restart();
        QuickSort(arr2, 0, arr2.Length - 1);
        sw.Stop();
        Console.WriteLine($"Quick Sort  [O(n log n)] (n = {n}): {sw.Elapsed.TotalMilliseconds:F6} ms");
    }

    #endregion

    #region PHẦN 3: MỤC 3.7.2

    // Mục 3.7.2 - Bài 1: Tính S(n) = 1 + 2 + 3 + ... + n bằng đệ quy
    static long Tong1(int n)
    {
        if (n == 1) return 1;
        return Tong1(n - 1) + n;
    }

    static void Muc3_7_2_Bai1()
    {
        Console.Write("Nhập n (> 0): ");
        int n = int.Parse(Console.ReadLine() ?? "1");
        Console.WriteLine($"S({n}) = {Tong1(n)}");
    }

    // Mục 3.7.2 - Bài 2: Tính S(n) = 1^2 + 2^2 + 3^2 + ... + n^2 bằng đệ quy
    static long Tong2(int n)
    {
        if (n == 1) return 1;
        return Tong2(n - 1) + (long)n * n;
    }

    static void Muc3_7_2_Bai2()
    {
        Console.Write("Nhập n (> 0): ");
        int n = int.Parse(Console.ReadLine() ?? "1");
        Console.WriteLine($"S({n}) = {Tong2(n)}");
    }

    // Mục 3.7.2 - Bài 3: Tính S(n) = 1 + 1/2 + 1/3 + ... + 1/n bằng đệ quy
    static double Tong3(int n)
    {
        if (n == 1) return 1;
        return Tong3(n - 1) + 1.0 / n;
    }

    static void Muc3_7_2_Bai3()
    {
        Console.Write("Nhập n (> 0): ");
        int n = int.Parse(Console.ReadLine() ?? "1");
        Console.WriteLine($"S({n}) = {Tong3(n):F4}");
    }

    // Mục 3.7.2 - Bài 4: Tính S(x, n) = x^n bằng đệ quy (hỗ trợ cả n âm và n dương)
    static double LuyThua(double x, int n)
    {
        if (n == 0) return 1;
        return LuyThua(x, n - 1) * x;
    }

    static double S_Mu(double x, int n)
    {
        if (n < 0) return 1.0 / LuyThua(x, -n);
        return LuyThua(x, n);
    }

    static void Muc3_7_2_Bai4()
    {
        Console.Write("Nhập x: ");
        double x = double.Parse(Console.ReadLine() ?? "1");
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"{x}^{n} = {S_Mu(x, n)}");
    }

    // Mục 3.7.2 - Bài 5: Tìm ước số lẻ lớn nhất của số nguyên dương n bằng đệ quy
    static int UocLeMax(int n)
    {
        if (n % 2 == 1) return n;
        return UocLeMax(n / 2);
    }

    static void Muc3_7_2_Bai5()
    {
        Console.Write("Nhập n (> 0): ");
        int n = int.Parse(Console.ReadLine() ?? "1");
        Console.WriteLine($"Ước lẻ lớn nhất của {n} là: {UocLeMax(n)}");
    }

    // Mục 3.7.2 - Bài 6: Tìm ước chung lớn nhất của 2 số nguyên dương a, b (Euclid)
    static int UCLN(int a, int b)
    {
        if (a % b == 0) return b;
        return UCLN(b, a % b);
    }

    static void Muc3_7_2_Bai6()
    {
        Console.Write("Nhập a (> 0): ");
        int a = int.Parse(Console.ReadLine() ?? "1");
        Console.Write("Nhập b (> 0): ");
        int b = int.Parse(Console.ReadLine() ?? "1");
        Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
    }

    // Mục 3.7.2 - Bài 7: Đếm số chữ số của số nguyên dương n bằng đệ quy
    static int SoChuSo(int n)
    {
        if (n == 0) return 0;
        return SoChuSo(n / 10) + 1;
    }

    static void Muc3_7_2_Bai7()
    {
        Console.Write("Nhập n (> 0): ");
        int n = int.Parse(Console.ReadLine() ?? "1");
        Console.WriteLine($"Số chữ số của {n} là: {SoChuSo(n)}");
    }

    // Mục 3.7.2 - Bài 8: Tính S(n) = sqrt(1 + sqrt(2 + ... + sqrt(n))) bằng đệ quy
    static double Can(int i, int n)
    {
        if (i == n) return Math.Sqrt(n);
        return Math.Sqrt(i + Can(i + 1, n));
    }

    static double S_Can(int n)
    {
        return Can(1, n);
    }

    static void Muc3_7_2_Bai8()
    {
        Console.Write("Nhập n (> 0): ");
        int n = int.Parse(Console.ReadLine() ?? "1");
        Console.WriteLine($"S({n}) = {S_Can(n):F4}");
    }

    #endregion
}