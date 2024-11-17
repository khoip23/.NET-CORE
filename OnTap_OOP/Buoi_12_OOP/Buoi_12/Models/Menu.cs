public class Menu
{
    public List<monAn> danhSachMonAn { get; set; } = new List<monAn>();

    public int Chon { get; set; }

    public void themMonAn(monAn monAnMoi)
    {
        danhSachMonAn.Add(monAnMoi);
    }

    public void HienThiChucNang()
    {
        System.Console.WriteLine(@$"
            1/ Thêm món ăn
            2/ Hiển thị menu
            3/ Xóa món ăn
            4/ Thoát
        ");
    }

    public void XoaMonAn()
    {
        System.Console.Write("Nhập mã món cần xóa: ");
        int maMonAnCanXoa = Convert.ToInt32(System.Console.ReadLine());

        // dựa vào mã món tìm ra object trong lst
        monAn? monAnTim = danhSachMonAn.Find(mon => mon.maMonAn == maMonAnCanXoa); // có được object món ăn đó hoặc null
        if (monAnTim != null)
        {
            //xóa món ăn đó ra khổi lst<monAn>
            danhSachMonAn.Remove(monAnTim);
        }
        else
        {
            System.Console.WriteLine("Mã món ăn không tồn tại!");
        }
    }

    public void ChonChucNang()
    {
        System.Console.Write("Nhập vào lựa chọn của bạn: ");
        Chon = Convert.ToInt32(Console.ReadLine());
    }

    public void HienThiMenu()
    {
        foreach(var mon in danhSachMonAn)
        {
            mon.xuatMonAn();
        }
    }

    public void Thoat()
    {
        Chon = 4;
    }
}