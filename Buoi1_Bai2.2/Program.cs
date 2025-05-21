namespace Buoi1_Bai2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Phương thức:
            //NhapThongTin() – nhập từ bàn phím
            //HienThiThongTin() – in ra thông tin
            //XepLoai() – trả về “Giỏi”, “Khá”, “Trung Bình”, “Yếu” theo điểm
            //Sau đó, tạo danh sách 3 sinh viên và hiển thị xếp loại của từng người.
            Sinhvien svA = new Sinhvien();
            Sinhvien svB = new Sinhvien();
            Sinhvien svC = new Sinhvien();
            List<Sinhvien> listSV = new List<Sinhvien>();
            listSV.Add(svA);
            listSV.Add(svB);
            listSV.Add(svC);
            foreach (var sv in listSV)
            {
                NhapThongTin(sv);
            }
            foreach (var sv in listSV)
            {
                Console.WriteLine(HienThiThongTin(sv));
            }
            foreach (var sv in listSV)
            {
                Console.WriteLine(XepLoai(sv));
            }
            //Vào dependencies => chọn project reference 
            HinhChuNhat hinhChuNhat = new HinhChuNhat(5, 10);// class phải là public , default chỉ đc cùng project
            Console.WriteLine(hinhChuNhat.ToString());
        }
        public static void NhapThongTin(Sinhvien sv)
        {
            Console.Write("Nhap MaSv : ");
            sv.MaSv = Console.ReadLine();

            Console.Write("Nhap ten sinh vien :");
            sv.TenSv = Console.ReadLine();

            Console.Write("Nhap diem TB :");
            sv.DiemTB = double.Parse(Console.ReadLine());

            Console.WriteLine("============================");
        }
        public static string HienThiThongTin(Sinhvien sv)
        {
            if (sv == null)
            {
                return "No information";
            }
            return "Sinh vien " + sv.TenSv + " MASV :" + sv.MaSv + " DiemTB :" + sv.DiemTB;
        }
        public static string XepLoai(Sinhvien sv)
        {
            if (sv == null)
            {
                return "Khong co diem";
            }
            else if (sv.DiemTB < 5 && sv.DiemTB > 4)
            {
                return "Trung Binh";
            }
            else if (sv.DiemTB > 5 && sv.DiemTB < 8)
            {
                return "Kha";
            }
            else if (sv.DiemTB >= 8)
            {
                return "Gioi";
            }
            else if (sv.DiemTB <= 4)
            {
                return "Yeu";
            }
            else
            {
                return "123";
            }

            //update

           
        }

    }
}
