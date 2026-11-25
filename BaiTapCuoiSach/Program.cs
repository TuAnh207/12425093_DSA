using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTapCuoiSach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n BÀI TẬP CUỐI SÁCH  ");
                Console.WriteLine("1. Bài 7: Quản lý nhiệt độ");
                Console.WriteLine("2. Bài 8: Thống kê từ");
                Console.WriteLine("3. Bài 9: Xử lý số nguyên");
                Console.WriteLine("4. Bài 10: Ma trận xoắn ốc");
                Console.WriteLine("5. Bài 11: Ma trận đặc biệt");
                Console.WriteLine("6. Bài 12: Game Minesweeper");
                Console.WriteLine("7. Bài 13: Đảo ngược danh sách");
                Console.WriteLine("8. Bài 14: Gộp danh sách");
                Console.WriteLine("9. Bài 15: Phát hiện chu trình");
                Console.WriteLine("10. Bài 16: Hệ thống lịch sử duyệt web");
                Console.WriteLine("11. Bài 17: Playlist nhạc");
                Console.WriteLine("12. Bài 18: Hệ thống đặt hàng");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn bài tập (0-12): ");

                string chon = Console.ReadLine() ?? "";
                Console.WriteLine();

                switch (chon)
                {
                    case "1": Bai7.Chay(); break;
                    case "2": Bai8.Chay(); break;
                    case "3": Bai9.Chay(); break;
                    case "4": Bai10.Chay(); break;
                    case "5": Bai11.Chay(); break;
                    case "6": Bai12.Chay(); break;
                    case "7": Bai13.Chay(); break;
                    case "8": Bai14.Chay(); break;
                    case "9": Bai15.Chay(); break;
                    case "10": Bai16.Chay(); break;
                    case "11": Bai17.Chay(); break;
                    case "12": Bai18.Chay(); break;
                    case "0":
                        Console.WriteLine("Đã thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn từ 0 đến 12.");
                        break;
                }
            }
        }

        class Bai7
        {
            public static void Chay()
            {
                Console.WriteLine(" Bài 7: Quản lý nhiệt độ ");
                int n;
                while (true)
                {
                    Console.Write("Nhập số lượng ngày (n > 0): ");
                    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                        break;
                    Console.WriteLine("Vui lòng nhập một số nguyên dương.");
                }

                double[] nhietDo = new double[n];
                for (int i = 0; i < n; i++)
                {
                    while (true)
                    {
                        Console.Write($"Nhập nhiệt độ ngày thứ {i + 1}: ");
                        if (double.TryParse(Console.ReadLine(), out nhietDo[i]))
                            break;
                        Console.WriteLine("Vui lòng nhập một số hợp lệ.");
                    }
                }

                double min = nhietDo[0], max = nhietDo[0];
                int ngayMax = 1, ngayMin = 1;
                double tong = 0;

                for (int i = 0; i < n; i++)
                {
                    tong += nhietDo[i];
                    if (nhietDo[i] > max)
                    {
                        max = nhietDo[i];
                        ngayMax = i + 1;
                    }
                    if (nhietDo[i] < min)
                    {
                        min = nhietDo[i];
                        ngayMin = i + 1;
                    }
                }

                double trungBinh = tong / n;
                Console.WriteLine("\n Kết quả ");
                Console.WriteLine($"Nhiệt độ cao nhất: {max}°C vào ngày {ngayMax}");
                Console.WriteLine($"Nhiệt độ thấp nhất: {min}°C vào ngày {ngayMin}");
                Console.WriteLine($"Nhiệt độ trung bình: {trungBinh:F2}°C");
            }
        }

        class Bai8
        {
            public static void Chay()
            {
                Console.WriteLine(" Bài 8: Thống kê từ ");
                Console.Write("Nhập một chuỗi văn bản: ");
                string input = Console.ReadLine() ?? "";

                StringBuilder sb = new StringBuilder();
                foreach (char c in input.ToLower())
                {
                    if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                        sb.Append(c);
                    else
                        sb.Append(' ');
                }

                string[] tu = sb.ToString().Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if (tu.Length == 0)
                {
                    Console.WriteLine("Chuỗi không có từ nào hợp lệ.");
                    return;
                }

                Dictionary<string, int> tanSuat = new Dictionary<string, int>();
                foreach (string w in tu)
                {
                    if (tanSuat.ContainsKey(w))
                        tanSuat[w]++;
                    else
                        tanSuat[w] = 1;
                }

                var ketQua = tanSuat.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                Console.WriteLine("\n--- Kết quả thống kê ---");
                foreach (var item in ketQua)
                {
                    Console.WriteLine($"- \"{item.Key}\": {item.Value} lần");
                }
            }
        }

        class Bai9
        {
            static bool LaSoNguyenTo(int x)
            {
                if (x < 2) return false;
                for (int i = 2; i * i <= x; i++)
                {
                    if (x % i == 0) return false;
                }
                return true;
            }

            static bool LaSoHoanHao(int x)
            {
                if (x <= 1) return false;
                int tongUoc = 1;
                for (int i = 2; i * i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        tongUoc += i;
                        if (i != x / i) tongUoc += x / i;
                    }
                }
                return tongUoc == x;
            }

            public static void Chay()
            {
                Console.WriteLine(" Bài 9: Xử lý số nguyên ");
                int n;
                while (true)
                {
                    Console.Write("Nhập số lượng phần tử n: ");
                    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                        break;
                    Console.WriteLine("Vui lòng nhập số nguyên dương.");
                }

                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    while (true)
                    {
                        Console.Write($"Nhập phần tử a[{i}]: ");
                        if (int.TryParse(Console.ReadLine(), out a[i]))
                            break;
                        Console.WriteLine("Vui lòng nhập số nguyên hợp lệ.");
                    }
                }

                List<int> soNguyenTo = new List<int>();
                List<int> soChan = new List<int>();
                List<int> soHoanHao = new List<int>();

                foreach (int x in a)
                {
                    if (LaSoNguyenTo(x)) soNguyenTo.Add(x);
                    if (x % 2 == 0) soChan.Add(x);
                    if (LaSoHoanHao(x)) soHoanHao.Add(x);
                }

                Console.WriteLine("\n Kết quả ");
                Console.WriteLine($"Số nguyên tố ({soNguyenTo.Count}): {(soNguyenTo.Count > 0 ? string.Join(", ", soNguyenTo) : "Không có")}");
                Console.WriteLine($"Số chẵn ({soChan.Count}): {(soChan.Count > 0 ? string.Join(", ", soChan) : "Không có")}");
                Console.WriteLine($"Số hoàn hảo ({soHoanHao.Count}): {(soHoanHao.Count > 0 ? string.Join(", ", soHoanHao) : "Không có")}");
            }
        }

        class Bai10
        {
            static int NhapSoDuong(string thongBao)
            {
                int x;
                while (true)
                {
                    Console.Write(thongBao);
                    if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                        return x;
                    Console.WriteLine("Vui lòng nhập số nguyên dương.");
                }
            }

            public static void Chay()
            {
                Console.WriteLine(" Bài 10: Ma trận xoắn ốc ");
                int m = NhapSoDuong("Nhập số dòng m: ");
                int n = NhapSoDuong("Nhập số cột n: ");

                int[,] matrix = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        while (true)
                        {
                            Console.Write($"Nhập matrix[{i},{j}]: ");
                            if (int.TryParse(Console.ReadLine(), out matrix[i, j]))
                                break;
                            Console.WriteLine("Vui lòng nhập số nguyên.");
                        }
                    }
                }

                Console.WriteLine("\nMa trận vừa nhập:");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write($"{matrix[i, j],5}");
                    Console.WriteLine();
                }

                int top = 0, bottom = m - 1, left = 0, right = n - 1;
                List<int> ketQua = new List<int>();

                while (top <= bottom && left <= right)
                {
                    for (int j = left; j <= right; j++)
                        ketQua.Add(matrix[top, j]);
                    top++;

                    for (int i = top; i <= bottom; i++)
                        ketQua.Add(matrix[i, right]);
                    right--;

                    if (top <= bottom)
                    {
                        for (int j = right; j >= left; j--)
                            ketQua.Add(matrix[bottom, j]);
                        bottom--;
                    }

                    if (left <= right)
                    {
                        for (int i = bottom; i >= top; i--)
                            ketQua.Add(matrix[i, left]);
                        left++;
                    }
                }

                Console.WriteLine("\nThứ tự xoắn ốc:");
                Console.WriteLine(string.Join(" ", ketQua));
            }
        }

        class Bai11
        {
            static int NhapSoDuong(string thongBao)
            {
                int x;
                while (true)
                {
                    Console.Write(thongBao);
                    if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                        return x;
                    Console.WriteLine("Vui lòng nhập số nguyên dương.");
                }
            }

            static bool LaMaTranDonVi(int[,] matrix, int m, int n)
            {
                if (m != n) return false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j && matrix[i, j] != 1) return false;
                        if (i != j && matrix[i, j] != 0) return false;
                    }
                }
                return true;
            }

            static bool LaMaTranDoiXung(int[,] matrix, int m, int n)
            {
                if (m != n) return false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (matrix[i, j] != matrix[j, i]) return false;
                    }
                }
                return true;
            }

            public static void Chay()
            {
                Console.WriteLine(" Bài 11: Ma trận đặc biệt ");
                int m = NhapSoDuong("Nhập số dòng m: ");
                int n = NhapSoDuong("Nhập số cột n: ");

                int[,] matrix = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        while (true)
                        {
                            Console.Write($"Nhập matrix[{i},{j}]: ");
                            if (int.TryParse(Console.ReadLine(), out matrix[i, j]))
                                break;
                            Console.WriteLine("Vui lòng nhập số nguyên.");
                        }
                    }
                }

                Console.WriteLine("\nMa trận vừa nhập:");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write($"{matrix[i, j],5}");
                    Console.WriteLine();
                }

                Console.WriteLine("\n--- Kết quả ---");
                Console.WriteLine($"Ma trận đơn vị: {(LaMaTranDonVi(matrix, m, n) ? "CÓ" : "KHÔNG")}");
                Console.WriteLine($"Ma trận đối xứng: {(LaMaTranDoiXung(matrix, m, n) ? "CÓ" : "KHÔNG")}");
            }
        }

        class Bai12
        {
            static int NhapSoDuong(string thongBao)
            {
                int x;
                while (true)
                {
                    Console.Write(thongBao);
                    if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                        return x;
                    Console.WriteLine("Vui lòng nhập số nguyên dương.");
                }
            }

            public static void Chay()
            {
                Console.WriteLine(" Bài 12: Game Minesweeper ");
                int m = NhapSoDuong("Nhập số dòng m: ");
                int n = NhapSoDuong("Nhập số cột n: ");

                int soMin;
                while (true)
                {
                    Console.Write($"Nhập số lượng mìn (0 - {m * n}): ");
                    if (int.TryParse(Console.ReadLine(), out soMin) && soMin >= 0 && soMin <= m * n)
                        break;
                    Console.WriteLine($"Vui lòng nhập số từ 0 đến {m * n}.");
                }

                bool[,] coMin = new bool[m, n];
                Random rnd = new Random();
                int daDat = 0;
                while (daDat < soMin)
                {
                    int r = rnd.Next(m);
                    int c = rnd.Next(n);
                    if (!coMin[r, c])
                    {
                        coMin[r, c] = true;
                        daDat++;
                    }
                }

                int[,] bang = new int[m, n];
                int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
                int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (coMin[i, j])
                        {
                            bang[i, j] = -1;
                            continue;
                        }

                        int dem = 0;
                        for (int k = 0; k < 8; k++)
                        {
                            int ni = i + dx[k];
                            int nj = j + dy[k];
                            if (ni >= 0 && ni < m && nj >= 0 && nj < n && coMin[ni, nj])
                                dem++;
                        }
                        bang[i, j] = dem;
                    }
                }

                Console.WriteLine("\nBảng Minesweeper (* là mìn):");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (bang[i, j] == -1)
                            Console.Write("  *");
                        else
                            Console.Write($"{bang[i, j],3}");
                    }
                    Console.WriteLine();
                }
            }
        }

        class Bai13
        {
            class Node
            {
                public int Data;
                public Node? Next;
                public Node(int data) { Data = data; }
            }

            static void InDanhSach(Node? head)
            {
                if (head == null)
                {
                    Console.WriteLine("(Danh sách rỗng)");
                    return;
                }
                Node? p = head;
                while (p != null)
                {
                    Console.Write(p.Data + (p.Next != null ? " -> " : ""));
                    p = p.Next;
                }
                Console.WriteLine();
            }

            static Node? DaoNguoc(Node? head)
            {
                Node? previous = null;
                Node? current = head;
                Node? next = null;

                while (current != null)
                {
                    next = current.Next;
                    current.Next = previous;
                    previous = current;
                    current = next;
                }
                return previous;
            }

            public static void Chay()
            {
                Console.WriteLine(" Bài 13: Đảo ngược danh sách liên kết đơn ");
                int n;
                while (true)
                {
                    Console.Write("Nhập số lượng phần tử n: ");
                    if (int.TryParse(Console.ReadLine(), out n) && n >= 0)
                        break;
                    Console.WriteLine("Vui lòng nhập số nguyên không âm.");
                }

                Node? head = null;
                Node? tail = null;

                for (int i = 0; i < n; i++)
                {
                    int val;
                    while (true)
                    {
                        Console.Write($"Nhập phần tử thứ {i + 1}: ");
                        if (int.TryParse(Console.ReadLine(), out val))
                            break;
                        Console.WriteLine("Vui lòng nhập số nguyên.");
                    }

                    Node moi = new Node(val);
                    if (head == null)
                        head = tail = moi;
                    else
                    {
                        tail!.Next = moi;
                        tail = moi;
                    }
                }

                Console.Write("\nDanh sách ban đầu:   ");
                InDanhSach(head);

                head = DaoNguoc(head);

                Console.Write("Danh sách đảo ngược: ");
                InDanhSach(head);
            }
        }

        class Bai14
        {
            class Node
            {
                public int Data;
                public Node? Next;
                public Node(int data) { Data = data; }
            }

            static Node? NhapDanhSachTangDan(string tenDS)
            {
                int n;
                while (true)
                {
                    Console.Write($"Nhập số phần tử của {tenDS}: ");
                    if (int.TryParse(Console.ReadLine(), out n) && n >= 0)
                        break;
                    Console.WriteLine("Vui lòng nhập số nguyên không âm.");
                }

                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    while (true)
                    {
                        Console.Write($"  {tenDS}[{i}]: ");
                        if (int.TryParse(Console.ReadLine(), out arr[i]))
                            break;
                        Console.WriteLine("  Vui lòng nhập số nguyên.");
                    }
                }

                Array.Sort(arr);

                Node? head = null;
                Node? tail = null;
                foreach (int x in arr)
                {
                    Node moi = new Node(x);
                    if (head == null) head = tail = moi;
                    else
                    {
                        tail!.Next = moi;
                        tail = moi;
                    }
                }
                return head;
            }

            static Node? GopDanhSach(Node? l1, Node? l2)
            {
                Node dummy = new Node(0);
                Node tail = dummy;

                while (l1 != null && l2 != null)
                {
                    if (l1.Data <= l2.Data)
                    {
                        tail.Next = l1;
                        l1 = l1.Next;
                    }
                    else
                    {
                        tail.Next = l2;
                        l2 = l2.Next;
                    }
                    tail = tail.Next;
                }

                tail.Next = (l1 != null) ? l1 : l2;
                return dummy.Next;
            }

            static void InDanhSach(Node? head)
            {
                if (head == null)
                {
                    Console.WriteLine("(Rỗng)");
                    return;
                }
                Node? p = head;
                while (p != null)
                {
                    Console.Write(p.Data + (p.Next != null ? " -> " : ""));
                    p = p.Next;
                }
                Console.WriteLine();
            }

            public static void Chay()
            {
                Console.WriteLine(" Bài 14: Gộp danh sách đã sắp xếp ");
                Node? ds1 = NhapDanhSachTangDan("Danh sách 1");
                Node? ds2 = NhapDanhSachTangDan("Danh sách 2");

                Console.Write("\nDanh sách 1: ");
                InDanhSach(ds1);
                Console.Write("Danh sách 2: ");
                InDanhSach(ds2);

                Node? ketQua = GopDanhSach(ds1, ds2);
                Console.Write("Sau khi gộp: ");
                InDanhSach(ketQua);
            }
        }

        class Bai15
        {
            class Node
            {
                public int Data;
                public Node? Next;
                public Node(int data) { Data = data; }
            }

            static bool PhatHienChuTrinh(Node? head)
            {
                Node? rua = head;
                Node? tho = head;

                while (tho != null && tho.Next != null)
                {
                    rua = rua!.Next;
                    tho = tho.Next.Next;

                    if (rua == tho)
                        return true;
                }
                return false;
            }

            public static void Chay()
            {
                Console.WriteLine(" Bài 15: Phát hiện chu trình (Floyd - Rùa và Thỏ) ");
                int n;
                while (true)
                {
                    Console.Write("Nhập số nút n: ");
                    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                        break;
                    Console.WriteLine("Vui lòng nhập số nguyên dương.");
                }

                List<Node> danhSachNut = new List<Node>();
                for (int i = 0; i < n; i++)
                {
                    int val;
                    while (true)
                    {
                        Console.Write($"Nhập giá trị nút {i + 1}: ");
                        if (int.TryParse(Console.ReadLine(), out val))
                            break;
                        Console.WriteLine("Vui lòng nhập số nguyên.");
                    }

                    Node moi = new Node(val);
                    if (danhSachNut.Count > 0)
                        danhSachNut[danhSachNut.Count - 1].Next = moi;
                    danhSachNut.Add(moi);
                }

                int viTriNoi;
                while (true)
                {
                    Console.Write($"Nối nút cuối quay lại nút thứ mấy để tạo chu trình? (1-{n}, hoặc 0 nếu KHÔNG tạo): ");
                    if (int.TryParse(Console.ReadLine(), out viTriNoi) && viTriNoi >= 0 && viTriNoi <= n)
                        break;
                    Console.WriteLine($"Vui lòng nhập từ 0 đến {n}.");
                }

                if (viTriNoi > 0)
                {
                    danhSachNut[n - 1].Next = danhSachNut[viTriNoi - 1];
                    Console.WriteLine($"Đã nối nút cuối ({danhSachNut[n - 1].Data}) -> nút thứ {viTriNoi} ({danhSachNut[viTriNoi - 1].Data}).");
                }

                bool coChuTrinh = PhatHienChuTrinh(danhSachNut[0]);
                Console.WriteLine($"\nKết quả: {(coChuTrinh ? "CÓ chu trình trong danh sách." : "KHÔNG có chu trình.")}");
            }
        }

        class Bai16
        {
            class PageNode
            {
                public string Url;
                public PageNode? Prev;
                public PageNode? Next;
                public PageNode(string url) { Url = url; }
            }

            public static void Chay()
            {
                Console.WriteLine(" Bài 16: Hệ thống lịch sử duyệt web ");
                PageNode? head = null;
                PageNode? current = null;

                while (true)
                {
                    Console.WriteLine($"\nTrang hiện tại: {(current != null ? current.Url : "(Chưa mở trang nào)")}");
                    Console.WriteLine("1. Truy cập trang web mới");
                    Console.WriteLine("2. Back (Quay lại trang trước)");
                    Console.WriteLine("3. Forward (Đi tới trang sau)");
                    Console.WriteLine("4. Xem toàn bộ lịch sử");
                    Console.WriteLine("0. Quay lại menu chính");
                    Console.Write("Chọn chức năng: ");

                    string chon = Console.ReadLine() ?? "";
                    switch (chon)
                    {
                        case "1":
                            Console.Write("Nhập địa chỉ URL: ");
                            string url = (Console.ReadLine() ?? "").Trim();
                            if (string.IsNullOrEmpty(url))
                            {
                                Console.WriteLine("URL không được để trống.");
                                break;
                            }
                            PageNode moi = new PageNode(url);
                            if (current == null)
                            {
                                head = current = moi;
                            }
                            else
                            {
                                current.Next = moi;
                                moi.Prev = current;
                                current = moi;
                            }
                            Console.WriteLine($"Đã mở: {url}");
                            break;

                        case "2":
                            if (current?.Prev != null)
                            {
                                current = current.Prev;
                                Console.WriteLine($"Back -> {current.Url}");
                            }
                            else
                                Console.WriteLine("Không thể Back (đang ở trang đầu tiên).");
                            break;

                        case "3":
                            if (current?.Next != null)
                            {
                                current = current.Next;
                                Console.WriteLine($"Forward -> {current.Url}");
                            }
                            else
                                Console.WriteLine("Không thể Forward (đang ở trang mới nhất).");
                            break;

                        case "4":
                            if (head == null)
                            {
                                Console.WriteLine("Lịch sử đang trống.");
                            }
                            else
                            {
                                Console.WriteLine("Lịch sử duyệt web:");
                                PageNode? p = head;
                                while (p != null)
                                {
                                    string danhDau = (p == current) ? "  <-- [Đang xem]" : "";
                                    Console.WriteLine($"- {p.Url}{danhDau}");
                                    p = p.Next;
                                }
                            }
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Chọn từ 0 đến 4.");
                            break;
                    }
                }
            }
        }

        class Bai17
        {
            class SongNode
            {
                public string TenBai;
                public string CaSi;
                public SongNode? Prev;
                public SongNode? Next;

                public SongNode(string tenBai, string caSi)
                {
                    TenBai = tenBai;
                    CaSi = caSi;
                }
            }

            public static void Chay()
            {
                Console.WriteLine(" Bài 17: Playlist nhạc ");
                SongNode? head = null;
                SongNode? tail = null;
                SongNode? current = null;

                while (true)
                {
                    Console.WriteLine($"\nĐang phát: {(current != null ? $"{current.TenBai} - {current.CaSi}" : "(Playlist trống)")}");
                    Console.WriteLine("1. Thêm bài hát");
                    Console.WriteLine("2. Xóa bài hát theo tên");
                    Console.WriteLine("3. Bài tiếp theo (Next)");
                    Console.WriteLine("4. Bài trước đó (Previous)");
                    Console.WriteLine("5. Xem danh sách Playlist");
                    Console.WriteLine("0. Quay lại menu chính");
                    Console.Write("Chọn chức năng: ");

                    string chon = Console.ReadLine() ?? "";
                    switch (chon)
                    {
                        case "1":
                            Console.Write("Nhập tên bài hát: ");
                            string ten = (Console.ReadLine() ?? "").Trim();
                            Console.Write("Nhập tên ca sĩ: ");
                            string caSi = (Console.ReadLine() ?? "").Trim();
                            if (string.IsNullOrEmpty(ten))
                            {
                                Console.WriteLine("Tên bài hát không được để trống.");
                                break;
                            }

                            SongNode moi = new SongNode(ten, string.IsNullOrEmpty(caSi) ? "Chưa rõ" : caSi);
                            if (head == null)
                            {
                                head = tail = current = moi;
                            }
                            else
                            {
                                tail!.Next = moi;
                                moi.Prev = tail;
                                tail = moi;
                            }
                            Console.WriteLine($"Đã thêm \"{moi.TenBai}\" vào playlist.");
                            break;

                        case "2":
                            if (head == null)
                            {
                                Console.WriteLine("Playlist đang trống.");
                                break;
                            }
                            Console.Write("Nhập tên bài hát cần xóa: ");
                            string tenXoa = (Console.ReadLine() ?? "").Trim();

                            SongNode? p = head;
                            while (p != null && !p.TenBai.Equals(tenXoa, StringComparison.OrdinalIgnoreCase))
                                p = p.Next;

                            if (p == null)
                            {
                                Console.WriteLine("Không tìm thấy bài hát này.");
                            }
                            else
                            {
                                if (p.Prev != null) p.Prev.Next = p.Next;
                                else head = p.Next;

                                if (p.Next != null) p.Next.Prev = p.Prev;
                                else tail = p.Prev;

                                if (p == current)
                                    current = p.Next ?? p.Prev;

                                Console.WriteLine($"Đã xóa bài hát \"{p.TenBai}\".");
                            }
                            break;

                        case "3":
                            if (current?.Next != null)
                            {
                                current = current.Next;
                                Console.WriteLine($"Next -> {current.TenBai} - {current.CaSi}");
                            }
                            else
                                Console.WriteLine("Đã ở cuối playlist.");
                            break;

                        case "4":
                            if (current?.Prev != null)
                            {
                                current = current.Prev;
                                Console.WriteLine($"Previous -> {current.TenBai} - {current.CaSi}");
                            }
                            else
                                Console.WriteLine("Đã ở đầu playlist.");
                            break;

                        case "5":
                            if (head == null)
                            {
                                Console.WriteLine("Playlist đang trống.");
                            }
                            else
                            {
                                Console.WriteLine("Danh sách phát:");
                                SongNode? cur = head;
                                int stt = 1;
                                while (cur != null)
                                {
                                    string danhDau = (cur == current) ? "  <-- [Đang phát]" : "";
                                    Console.WriteLine($"{stt++}. {cur.TenBai} - {cur.CaSi}{danhDau}");
                                    cur = cur.Next;
                                }
                            }
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Chọn từ 0 đến 5.");
                            break;
                    }
                }
            }
        }

        class Bai18
        {
            class TrangThaiNode
            {
                public string Ten;
                public TrangThaiNode? Prev;
                public TrangThaiNode? Next;
                public TrangThaiNode(string ten) { Ten = ten; }
            }

            class DonHangNode
            {
                public int MaDon;
                public string TenKhach;
                public string SanPham;
                public TrangThaiNode TrangThai;
                public DonHangNode? Prev;
                public DonHangNode? Next;

                public DonHangNode(int maDon, string tenKhach, string sanPham, TrangThaiNode trangThaiDau)
                {
                    MaDon = maDon;
                    TenKhach = tenKhach;
                    SanPham = sanPham;
                    TrangThai = trangThaiDau;
                }

                public void TienTrangThai()
                {
                    if (TrangThai.Next != null)
                    {
                        TrangThai = TrangThai.Next;
                        Console.WriteLine($"Đơn #{MaDon} chuyển sang trạng thái: {TrangThai.Ten}");
                    }
                    else
                        Console.WriteLine($"Đơn #{MaDon} đã ở trạng thái cuối ({TrangThai.Ten}).");
                }

                public void LuiTrangThai()
                {
                    if (TrangThai.Prev != null)
                    {
                        TrangThai = TrangThai.Prev;
                        Console.WriteLine($"Đơn #{MaDon} quay lại trạng thái: {TrangThai.Ten}");
                    }
                    else
                        Console.WriteLine($"Đơn #{MaDon} đang ở trạng thái đầu ({TrangThai.Ten}).");
                }
            }

            static TrangThaiNode TaoChuoiTrangThai()
            {
                TrangThaiNode choXuLy = new TrangThaiNode("Chờ xử lý");
                TrangThaiNode dangGiao = new TrangThaiNode("Đang giao");
                TrangThaiNode hoanThanh = new TrangThaiNode("Hoàn thành");

                choXuLy.Next = dangGiao;
                dangGiao.Prev = choXuLy;
                dangGiao.Next = hoanThanh;
                hoanThanh.Prev = dangGiao;

                return choXuLy;
            }

            static DonHangNode? TimDonHang(DonHangNode? head, int maDon)
            {
                DonHangNode? p = head;
                while (p != null)
                {
                    if (p.MaDon == maDon) return p;
                    p = p.Next;
                }
                return null;
            }

            public static void Chay()
            {
                Console.WriteLine(" Bài 18: Hệ thống đặt hàng ");
                TrangThaiNode trangThaiMacDinh = TaoChuoiTrangThai();
                DonHangNode? head = null;
                DonHangNode? tail = null;
                int maTuTang = 1;

                while (true)
                {
                    Console.WriteLine("\n1. Tạo đơn hàng mới");
                    Console.WriteLine("2. Xem danh sách đơn hàng");
                    Console.WriteLine("3. Chuyển sang trạng thái tiếp theo (Chờ xử lý -> Đang giao -> Hoàn thành)");
                    Console.WriteLine("4. Quay lại trạng thái trước");
                    Console.WriteLine("0. Quay lại menu chính");
                    Console.Write("Chọn chức năng: ");

                    string chon = Console.ReadLine() ?? "";
                    switch (chon)
                    {
                        case "1":
                            Console.Write("Nhập tên khách hàng: ");
                            string khach = (Console.ReadLine() ?? "").Trim();
                            Console.Write("Nhập tên sản phẩm: ");
                            string sp = (Console.ReadLine() ?? "").Trim();
                            if (string.IsNullOrEmpty(khach) || string.IsNullOrEmpty(sp))
                            {
                                Console.WriteLine("Thông tin không được để trống.");
                                break;
                            }

                            DonHangNode moi = new DonHangNode(maTuTang++, khach, sp, trangThaiMacDinh);
                            if (head == null)
                                head = tail = moi;
                            else
                            {
                                tail!.Next = moi;
                                moi.Prev = tail;
                                tail = moi;
                            }
                            Console.WriteLine($"Đã tạo đơn #{moi.MaDon} ({moi.SanPham}) - Trạng thái: {moi.TrangThai.Ten}");
                            break;

                        case "2":
                            if (head == null)
                            {
                                Console.WriteLine("Chưa có đơn hàng nào.");
                            }
                            else
                            {
                                Console.WriteLine("\nDanh sách đơn hàng:");
                                DonHangNode? p = head;
                                while (p != null)
                                {
                                    Console.WriteLine($"- Đơn #{p.MaDon} | Khách: {p.TenKhach} | SP: {p.SanPham} | Trạng thái: [{p.TrangThai.Ten}]");
                                    p = p.Next;
                                }
                            }
                            break;

                        case "3":
                        case "4":
                            if (head == null)
                            {
                                Console.WriteLine("Chưa có đơn hàng nào.");
                                break;
                            }
                            Console.Write("Nhập mã đơn hàng cần cập nhật: ");
                            if (!int.TryParse(Console.ReadLine(), out int ma))
                            {
                                Console.WriteLine("Mã đơn không hợp lệ.");
                                break;
                            }
                            DonHangNode? don = TimDonHang(head, ma);
                            if (don == null)
                                Console.WriteLine($"Không tìm thấy đơn hàng #{ma}.");
                            else if (chon == "3")
                                don.TienTrangThai();
                            else
                                don.LuiTrangThai();
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Chọn từ 0 đến 4.");
                            break;
                    }
                }
            }
        }
    }
}