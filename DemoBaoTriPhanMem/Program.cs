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
        double phiMoMo = 5000; // Bảo trì: Bổ sung phí giao dịch 5.000 VND
        return giaGoc + phiMoMo;
    }
}