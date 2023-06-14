using System;

namespace PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap phan so thu nhat:");
            string phanSo1 = Console.ReadLine();
            Console.WriteLine("Nhap phan so thu hai:");
            string phanSo2 = Console.ReadLine();

            string ketQua = CongPhanSo(phanSo1, phanSo2);

            Console.WriteLine(ketQua);
        }

        static string CongPhanSo(string phanSo1, string phanSo2)
        {
            // Chuyển đổi phân số từ chuỗi sang mảng các số nguyên
            string[] phanSo1Arr = phanSo1.Split('/');
            string[] phanSo2Arr = phanSo2.Split('/');

            int tuSo1 = int.Parse(phanSo1Arr[0]);
            int mauSo1 = int.Parse(phanSo1Arr[1]);

            int tuSo2 = int.Parse(phanSo2Arr[0]);
            int mauSo2 = int.Parse(phanSo2Arr[1]);

            // Tính tổng tử số và mẫu số
            int tuSoTong = tuSo1 * mauSo2 + tuSo2 * mauSo1;
            int mauSoTong = mauSo1 * mauSo2;

            // Rút gọn phân số kết quả
            int uocChung = TimUocChung(tuSoTong, mauSoTong);
            tuSoTong /= uocChung;
            mauSoTong /= uocChung;

            // Trả về kết quả phân số dưới dạng chuỗi
            return $"{tuSoTong}/{mauSoTong}";
        }

        static int TimUocChung(int a, int b)
        {
            while (b != 0)
            {
                int temp = a;
                a = b;
                b = temp % b;
            }

            return a;
        }
    }
}
