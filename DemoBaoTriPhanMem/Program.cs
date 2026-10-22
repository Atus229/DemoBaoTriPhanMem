using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== HE THONG THANH TOAN ===");
        double tongTien = TinhTongTien(100000);
        Console.WriteLine($"Tong tien can tra: {tongTien} VND");
    }

    // Hàm gốc đang có lỗi logic: Chưa tính phí giao dịch MoMo
    static double TinhTongTien(double giaGoc)
    {
        return giaGoc;
    }
}