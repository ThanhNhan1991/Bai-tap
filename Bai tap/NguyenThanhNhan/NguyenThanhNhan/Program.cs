using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan
{
    internal class Program
    {
        static List<CongViec> listCV = new List<CongViec>();
        static void Main(string[] args)
        {
            while (true)
            {
                DanhSachChucNang();
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        NhapThongTinCongViec();
                        break;
                    case 2:
                        XoaCongViec();
                        break;
                    case 3:
                        CapNhatTrangThai();
                        break;
                    case 4:
                        TimKiemCongViec();
                        break;
                    case 5:
                        SapXepCongViec();
                        break;
                    case 6:
                        HienThiCongViec();
                        break;
                    default:
                        Console.WriteLine("Chuc nang khong ton tai!");
                        break;
                }
                bool stop = DungChuongTrinh();
                if (stop) break;
            }
        }
        private static void DanhSachChucNang()
        {
            Console.WriteLine("1. Nhap thong tin cong viec can lam");
            Console.WriteLine("2. Xoa cong viec can lam da nhap theo vi tri");
            Console.WriteLine("3. Cap nhat trang thai cac cong viec can lam theo vi tri");
            Console.WriteLine("4. Tim kiem cong viec da tao theo ten");
            Console.WriteLine("5. Danh sach cac viec can lam theo do uu tien giam dan");
            Console.WriteLine("6. Hien thi toan bo cong viec da nhap");
            Console.WriteLine("--------------");
            Console.Write("Moi ban chon bai tap: ");
        }
        private static bool DungChuongTrinh()
        {
            Console.WriteLine();
            Console.WriteLine("Ban co muon dung chuong trinh?");
            Console.WriteLine("Phim bat ky de tiep tuc!");
            Console.WriteLine("ESC. De thoat chuong trinh");
            ConsoleKeyInfo str = Console.ReadKey();
            if (str.Key == ConsoleKey.Escape) return true;
            Console.Clear();
            return false;
        }
    public static void NhapThongTinCongViec()
        {
            Console.Write("Nhap Ten cong viec: ");
            string tencv = Console.ReadLine();

            Console.Write("Nhap Do uu tien: ");
            int douutien = int.Parse(Console.ReadLine());

            Console.Write("Nhap thong tin cong viec: ");
            string thongtincv = Console.ReadLine();

            Console.Write("Nhap trang thai cong viec: ");
            string trangthaicv = Console.ReadLine();

            CongViec cv = new CongViec(tencv, douutien,thongtincv, trangthaicv);
            listCV.Add(cv);
        }
        public static void XoaCongViec()
        {
            Console.Write("Nhap MSSV can xoa: ");
            int mssv = int.Parse(Console.ReadLine());
            //string hoten = Console.ReadLine(); //Van
            //Nguyen Van A
            //Nguyen Van B
            //Nguyen Van C
            //listSV.RemoveAll(c => c.HoTen.ToLower().Contains(hoten.ToLower()));
            listCV.Remove(0);
        }