using System;

namespace DemoBaoTriPhanMem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HE THONG THANH TOAN ===");
            double tongTien = ThanhToan.TinhTongTien(100000);
            Console.WriteLine($"Tong tien can tra: {tongTien} VND");
        }
    }
}