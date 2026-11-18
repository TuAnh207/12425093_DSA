using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\n BÀI TẬP BUỔI 02 ");
            Console.WriteLine("1. Bài 1: Chèn phần tử vào mảng");
            Console.WriteLine("2. Bài 2: Quản lý nhân viên");
            Console.WriteLine("3. Bài 3: Ma trận vuông");
            Console.WriteLine("4. Bài 4: Danh sách liên kết (đếm, phần tử dương nhỏ nhất, xóa)");
            Console.WriteLine("5. Bài 5: Danh sách liên kết (thống kê)");
            Console.WriteLine("0. Thoát");
            Console.Write("Mời bạn chọn (0-5): ");

            string chon = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (chon)
            {
                case "1": Bai1.Chay(); break;
                case "2": Bai2.Chay(); break;
                case "3": Bai3.Chay(); break;
                case "4": Bai4.Chay(); break;
                case "5": Bai5.Chay(); break;
                case "0":
                    Console.WriteLine("Đã thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Chọn từ 0 đến 5!");
                    break;
            }
        }
    }
}

static class Bai1
{
    static int[] NhapMang()
    {
        int n;
        do
        {
            Console.Write("Nhập số phần tử n (n > 0): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write($"Nhập a[{i}] (số nguyên dương): ");
            } while (!int.TryParse(Console.ReadLine(), out a[i]) || a[i] <= 0);
        }
        return a;
    }

    static void HienThiMang(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }

    static void ChenPhanTu(ref int[] a, int x, int k)
    {
        if (k < 0 || k > a.Length)
        {
            Console.WriteLine($"Vị trí chèn k = {k} không hợp lệ (chỉ nhận từ 0 đến {a.Length}).");
            return;
        }

        int[] tmp = new int[a.Length + 1];
        for (int i = 0; i <= k - 1; i++)
        {
            tmp[i] = a[i];
        }
        tmp[k] = x;
        for (int i = k; i <= a.Length - 1; i++)
        {
            tmp[i + 1] = a[i];
        }
        a = tmp;
    }

    public static void Chay()
    {
        Console.WriteLine(" BÀI 1: CHÈN PHẦN TỬ VÀO MẢNG ");
        int[] a = NhapMang();
        Console.WriteLine("\nDanh sách vừa nhập:");
        HienThiMang(a);

        int x, k;
        do
        {
            Console.Write("\nNhập giá trị nguyên dương x cần chèn: ");
        } while (!int.TryParse(Console.ReadLine(), out x) || x <= 0);

        Console.Write($"Nhập vị trí k cần chèn (từ 0 đến {a.Length}): ");
        while (!int.TryParse(Console.ReadLine(), out k) || k < 0 || k > a.Length)
        {
            Console.Write($"Vị trí không hợp lệ! Nhập lại k (0..{a.Length}): ");
        }

        ChenPhanTu(ref a, x, k);
        Console.WriteLine($"\nDanh sách sau khi chèn {x} vào vị trí {k}:");
        HienThiMang(a);
    }
}

static class Bai2
{
    struct NhanVien
    {
        public string MaNV;
        public string Hoten;
        public int Namsinh;
        public string Phongban;
        public int LuongCB;
        public int Thuong;
    }

    static NhanVien[] DS = Array.Empty<NhanVien>();

    static int thuclinh(int i)
    {
        return DS[i].LuongCB + DS[i].Thuong;
    }

    static int tongthuclinh()
    {
        int tong = 0;
        for (int i = 0; i < DS.Length; i++)
        {
            tong += thuclinh(i);
        }
        return tong;
    }

    public static void Chay()
    {
        Console.WriteLine(" BÀI 2: QUẢN LÝ NHÂN VIÊN ");
        Console.Write("Nhập số lượng nhân viên n: ");
        int n = Nhap.DocSo();
        DS = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin nhân viên thứ {i + 1}:");
            Console.Write("Mã NV: ");
            DS[i].MaNV = Nhap.DocChuoi();
            Console.Write("Họ tên: ");
            DS[i].Hoten = Nhap.DocChuoi();
            Console.Write("Năm sinh: ");
            DS[i].Namsinh = Nhap.DocSo();
            Console.Write("Phòng ban: ");
            DS[i].Phongban = Nhap.DocChuoi();
            Console.Write("Lương cơ bản: ");
            DS[i].LuongCB = Nhap.DocSo();
            Console.Write("Thưởng: ");
            DS[i].Thuong = Nhap.DocSo();
        }

        Console.WriteLine("\nTổng thực lĩnh tháng : " + tongthuclinh());

        int min = int.MaxValue;
        for (int i = 0; i < DS.Length; i++)
        {
            if (DS[i].LuongCB < min)
            {
                min = DS[i].LuongCB;
            }
        }
        Console.WriteLine("Lương cơ bản thấp nhất: " + min);

        Console.WriteLine("Danh sách nhân viên có lương cơ bản thấp nhất:");
        for (int i = 0; i < DS.Length; i++)
        {
            if (DS[i].LuongCB == min)
            {
                Console.WriteLine($"- Mã NV: {DS[i].MaNV}, Họ tên: {DS[i].Hoten}, Năm sinh: {DS[i].Namsinh}, Phòng ban: {DS[i].Phongban}, Lương CB: {DS[i].LuongCB}, Thưởng: {DS[i].Thuong}");
            }
        }

        int dem = 0;
        for (int i = 0; i < DS.Length; i++)
        {
            if (DS[i].Thuong >= 1200000)
            {
                dem++;
            }
        }
        Console.WriteLine("Số lượng nhân viên có thưởng >= 1.200.000: " + dem);

        for (int i = 0; i < DS.Length - 1; i++)
        {
            for (int j = 0; j < DS.Length - 1 - i; j++)
            {
                if (DS[j].Phongban.CompareTo(DS[j + 1].Phongban) > 0 || (DS[j].Phongban == DS[j + 1].Phongban && DS[j].MaNV.CompareTo(DS[j + 1].MaNV) < 0))
                {
                    NhanVien temp = DS[j];
                    DS[j] = DS[j + 1];
                    DS[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nDanh sách nhân viên sau khi sắp xếp theo phòng ban và mã NV:");
        for (int i = 0; i < DS.Length; i++)
        {
            Console.WriteLine($"- Mã NV: {DS[i].MaNV}, Họ tên: {DS[i].Hoten}, Năm sinh: {DS[i].Namsinh}, Phòng ban: {DS[i].Phongban}, Lương CB: {DS[i].LuongCB}, Thưởng: {DS[i].Thuong}");
        }

        Console.WriteLine("\nDanh sách nhân viên sau khi tăng lương cơ bản lên 5%:");
        for (int i = 0; i < DS.Length; i++)
        {
            DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
            Console.WriteLine($"- Mã NV: {DS[i].MaNV}, Họ tên: {DS[i].Hoten}, Năm sinh: {DS[i].Namsinh}, Phòng ban: {DS[i].Phongban}, Lương CB mới: {DS[i].LuongCB}, Thưởng: {DS[i].Thuong}, Thực lĩnh mới: {thuclinh(i)}");
        }
    }
}

static class Bai3
{
    static int[,] NhapMaTran(out int n)
    {
        do
        {
            Console.Write("Nhập cấp ma trận vuông n (0 < n < 100): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n >= 100);

        int[,] a = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = Nhap.DocSo();
            }
        }
        return a;
    }

    static void InMaTran(int[,] a, int n)
    {
        Console.WriteLine("\nMa trận vừa nhập:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{a[i, j],6}");
            }
            Console.WriteLine();
        }
    }

    static int TongMaTran(int[,] a, int n)
    {
        int t = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                t += a[i, j];
            }
        }
        return t;
    }

    static int DuongNhoNhat(int[,] a, int n)
    {
        int min = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] > 0 && a[i, j] < min)
                {
                    min = a[i, j];
                }
            }
        }
        return min == int.MaxValue ? -1 : min;
    }

    static int TongCheoPhu(int[,] a, int n)
    {
        int tong = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == (n - 1) - i)
                {
                    tong += a[i, j];
                }
            }
        }
        return tong;
    }

    static bool KiemTraCheoChinhTangDan(int[,] a, int n)
    {
        int[] tg = new int[n];
        for (int i = 0; i < n; i++)
        {
            tg[i] = a[i, i];
        }
        for (int i = 0; i <= n - 2; i++)
        {
            for (int j = i + 1; j <= n - 1; j++)
            {
                if (tg[i] >= tg[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static void Chay()
    {
        Console.WriteLine(" BÀI 3: MA TRẬN VUÔNG ");
        int[,] a = NhapMaTran(out int n);
        InMaTran(a, n);

        Console.WriteLine($"\na. Tổng các phần tử ma trận: {TongMaTran(a, n)}");

        int minDuong = DuongNhoNhat(a, n);
        if (minDuong == -1)
            Console.WriteLine("b. Ma trận không có phần tử dương.");
        else
            Console.WriteLine($"b. Giá trị dương nhỏ nhất: {minDuong}");

        Console.WriteLine($"c. Tổng các phần tử trên đường chéo phụ: {TongCheoPhu(a, n)}");
        Console.WriteLine($"d. Đường chéo chính tăng dần: {KiemTraCheoChinhTangDan(a, n)}");
    }
}

static class Nhap
{
    public static string DocChuoi()
    {
        return Console.ReadLine() ?? "";
    }

    public static int DocSo()
    {
        return int.Parse(Console.ReadLine() ?? "");
    }
}

class Node
{
    public int Data;
    public Node? Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

static class Bai4
{
    static Node? pHead = null;

    static void ThemCuoi(int val)
    {
        Node newNode = new Node(val);
        if (pHead == null)
        {
            pHead = newNode;
            return;
        }

        Node p = pHead;
        while (p.Next != null)
        {
            p = p.Next;
        }
        p.Next = newNode;
    }

    static void InDanhSach()
    {
        Node? p = pHead;
        while (p != null)
        {
            Console.Write(p.Data + " -> ");
            p = p.Next;
        }
        Console.WriteLine("null");
    }

    static int DemBangX(int x)
    {
        int d = 0;
        Node? p = pHead;
        while (p != null)
        {
            if (p.Data == x)
            {
                d = d + 1;
            }
            p = p.Next;
        }
        return d;
    }

    static int TimMinDuong()
    {
        int minduong = int.MaxValue;
        Node? p = pHead;
        while (p != null)
        {
            if (p.Data > 0 && p.Data < minduong)
            {
                minduong = p.Data;
            }
            p = p.Next;
        }
        return minduong == int.MaxValue ? -1 : minduong;
    }

    static void XoaPhanTuDauTien(int x)
    {
        Node? p = pHead;
        Node? t = null;
        while (p != null && p.Data != x)
        {
            t = p;
            p = p.Next;
        }

        if (p == null)
        {
            Console.WriteLine($"Không tìm thấy {x} trong danh sách.");
            return;
        }

        if (p == pHead)
        {
            pHead = pHead.Next;
        }
        else if (t != null)
        {
            t.Next = p.Next;
        }
    }

    public static void Chay()
    {
        Console.WriteLine(" BÀI 4: DANH SÁCH LIÊN KẾT ");
        pHead = null;

        Console.Write("Nhập số lượng phần tử n: ");
        int n = Nhap.DocSo();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1} (số nguyên dương): ");
            int val = Nhap.DocSo();
            ThemCuoi(val);
        }

        Console.WriteLine("\nDanh sách vừa nhập:");
        InDanhSach();

        Console.Write("\nNhập giá trị x cần đếm: ");
        int xDem = Nhap.DocSo();
        Console.WriteLine($"a. Số lượng phần tử bằng {xDem}: {DemBangX(xDem)}");

        int minD = TimMinDuong();
        Console.WriteLine($"b. Phần tử dương nhỏ nhất: {(minD == -1 ? "Không có" : minD.ToString())}");

        Console.Write("\nc. Nhập giá trị x cần xóa (xuất hiện đầu tiên): ");
        int xXoa = Nhap.DocSo();
        XoaPhanTuDauTien(xXoa);
        Console.WriteLine("Danh sách sau khi xóa:");
        InDanhSach();
    }
}

class Node5
{
    public int Data;
    public Node5? Next;

    public Node5(int data)
    {
        Data = data;
        Next = null;
    }
}

static class Bai5
{
    static Node5? l = null;

    static void ThemCuoi(int val)
    {
        Node5 newNode = new Node5(val);
        if (l == null)
        {
            l = newNode;
            return;
        }

        Node5 p = l;
        while (p.Next != null)
        {
            p = p.Next;
        }
        p.Next = newNode;
    }

    static int TimMax()
    {
        int max = int.MinValue;
        Node5? p = l;
        while (p != null)
        {
            if (p.Data > max)
            {
                max = p.Data;
            }
            p = p.Next;
        }
        return max;
    }

    static int TinhTong()
    {
        int t = 0;
        Node5? p = l;
        while (p != null)
        {
            t += p.Data;
            p = p.Next;
        }
        return t;
    }

    static bool KTNT(int x)
    {
        if (x < 2) return false;
        for (int i = 2; i <= Math.Sqrt(x); i++)
        {
            if (x % i == 0) return false;
        }
        return true;
    }

    static int DemSoNguyenTo()
    {
        int dem = 0;
        Node5? p = l;
        while (p != null)
        {
            if (KTNT(p.Data))
            {
                dem++;
            }
            p = p.Next;
        }
        return dem;
    }

    static void DemAmDuongKhong()
    {
        int demAm = 0, demDuong = 0, demKhong = 0;
        Node5? p = l;
        while (p != null)
        {
            if (p.Data < 0) demAm++;
            else if (p.Data > 0) demDuong++;
            else demKhong++;
            p = p.Next;
        }
        Console.WriteLine($"d. Số âm: {demAm} | Số dương: {demDuong} | Số bằng 0: {demKhong}");
    }

    static int DemBangX(int x)
    {
        int dem = 0;
        Node5? p = l;
        while (p != null)
        {
            if (p.Data == x)
            {
                dem++;
            }
            p = p.Next;
        }
        return dem;
    }

    static int TimMinDuong()
    {
        int minduong = int.MaxValue;
        Node5? p = l;
        while (p != null)
        {
            if (p.Data < minduong && p.Data > 0)
            {
                minduong = p.Data;
            }
            p = p.Next;
        }
        return minduong == int.MaxValue ? -1 : minduong;
    }

    public static void Chay()
    {
        Console.WriteLine(" BÀI 5: DANH SÁCH LIÊN KẾT (THỐNG KÊ) ");
        l = null;

        Console.Write("Nhập số lượng phần tử n: ");
        int n = Nhap.DocSo();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            int val = Nhap.DocSo();
            ThemCuoi(val);
        }

        Console.WriteLine($"\na. Phần tử lớn nhất: {TimMax()}");
        Console.WriteLine($"b. Tổng các phần tử: {TinhTong()}");
        Console.WriteLine($"c. Số lượng số nguyên tố: {DemSoNguyenTo()}");
        DemAmDuongKhong();

        Console.Write("\nNhập giá trị x cần đếm: ");
        int x = Nhap.DocSo();
        Console.WriteLine($"e. Số lượng phần tử bằng {x}: {DemBangX(x)}");

        int minD = TimMinDuong();
        Console.WriteLine($"f. Phần tử dương nhỏ nhất: {(minD == -1 ? "Không có" : minD.ToString())}");
    }
}