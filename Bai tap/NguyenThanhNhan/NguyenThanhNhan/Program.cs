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

            CongViec cv = new CongViec(tencv, douutien, thongtincv, trangthaicv);
            listCV.Add(cv);
        }
        public static void XoaCongViec()
        {
            HienThiCongViec();

            if (listCV.Count > 0)
            {
                Console.WriteLine("Chon vi tri cong viec can xoa (nhap so):");
                int viTri = Convert.ToInt32(Console.ReadLine()) - 1;

                if (viTri >= 0 && viTri < listCV.Count)
                {
                    listCV.RemoveAt(viTri);
                    Console.WriteLine("Cong viec đa đuoc xoa.");
                }
                else
                {
                    Console.WriteLine("So khong hop le. Vui long thu lai.");
                }
            }
        }
        public static void CapNhatTrangThai()
        {
            HienThiCongViec();
            if (listCV.Count > 0)
            {
                Console.WriteLine("Chon vi tri cong viec can cap nhat trang thai (nhap so):");
                int viTri = int.Parse(Console.ReadLine()) - 1;

                if (viTri >= 0 && viTri < listCV.Count)
                {
                    Console.WriteLine("Nhap trang thai moi (vi du: Hoan thanh, Chua hoan thnh):");
                    string trangthaimoi = Console.ReadLine();

                    listCV[viTri].TrangThaiCV = trangthaimoi;

                    Console.WriteLine("Trang thai cong viec đa đuoc cap nhat.");
                }
                else
                {
                    Console.WriteLine("So khong hop le. Vui long thu lai.");
                }
            }
        }
        public static void TimKiemCongViec()
        {
            Console.WriteLine("Nhap ten cong viec can tim kiem:");
            string TimTen = Console.ReadLine();

            var ketqua = listCV.Where(task => task.TenCV.Contains(TimTen)).ToList();

            if (ketqua.Count > 0)
            {
                Console.WriteLine("Ket qua tim kiem:");
                HienThi(ketqua);
            }
            else
            {
                Console.WriteLine("Khong tim thay cong viec nao.");
            }
        }
        public static void SapXepCongViec()
        {
            var sapxepgiam = listCV.OrderByDescending(task => task.DoUuTien).ToList();

            Console.WriteLine("Danh sach cong viec theo do uu tien giam dan:");
            HienThi(sapxepgiam);
        }
        public static void HienThiCongViec()
        {
            foreach (var item in listCV)
            {
                Console.WriteLine("Ten cong viec: {0}", item.TenCV);
                Console.WriteLine("Do uu tien: {0}", item.DoUuTien);
                Console.WriteLine("Thong tin cong viec: {0}", item.ThongTinCV);
                Console.WriteLine("Trang thai: {0}", item.TrangThaiCV);
                Console.WriteLine();
            }
        }
        static void HienThi(List<CongViec> congViecs)
        {
            if (congViecs.Count == 0)
            {
                Console.WriteLine("Khong co cong viec.");
            }
            else
            {
                for (int i = 0; i < congViecs.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {congViecs[i].TenCV} - Do uu tien: {congViecs[i].DoUuTien}- Thong tin cong viec: {congViecs[i].ThongTinCV} - Trang thai: {congViecs[i].TrangThaiCV}");
                }
            }
        }
    }
}
