public class Menu
{
    public List<monAn>? danhSachMonAn { get; set; } = new List<monAn>();

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

    public void ChonChucNang()
    {
        System.Console.Write("Nhập vào lựa chọn của bạn: ");
        Chon = Convert.ToInt32(Console.ReadLine());
    }

    public void Thoat()
    {
        Chon = 4;
    }
}