using System;
using System.Collections.Generic;

abstract class SanPham
{
    public string MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public double GiaGoc { get; set; }

    public SanPham(string ma, string ten, double giaGoc)
    {
        MaSanPham = ma;
        TenSanPham = ten;
        GiaGoc = giaGoc;
    }

    public abstract double TinhGiaBan(); // Phương thức trừu tượng để tính giá bán

    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Mã sản phẩm: {MaSanPham}, Tên sản phẩm: {TenSanPham}, Giá bán: {TinhGiaBan()}");
    }
}
