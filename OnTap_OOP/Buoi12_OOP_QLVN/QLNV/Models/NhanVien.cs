class NhanVien
{
    public static int idNhanVien = 1; // dùng cho tất cả nv
    public int maNhanVien {get; set;}
    public string hoTen {get; set;}
    public double luong1h {get; set;}
    public double soGioLam {get; set;}

    public NhanVien()
    {
        NhapThongTin();
        maNhanVien = idNhanVien;
        NhanVien.idNhanVien ++;
    }
    public void NhapThongTin()
    {
        maNhanVien = idNhanVien;

        System.Console.Write("Nhập họ và tên");
        hoTen = Console.ReadLine();

        System.Console.Write("Nhập vào lương 1 giờ:");
        luong1h = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập vào số giờ làm: ");
        soGioLam = Convert.ToDouble(Console.ReadLine());

        //thuộc tính của class không phải của đối tượng được new ra từ nhân viên
        NhanVien.idNhanVien++;
    }

    public void XuatThongTin()
    {
        System.Console.WriteLine(@$"
            ------Thông tin nhân viên {hoTen}
            Mã số : {maNhanVien}
            Họ tên: {hoTen}
            Lương 1h: {luong1h}
            Lương: {TinhLuong()} làm: {soGioLam}
        ");
    }

    private double TinhLuong()
    {
        return soGioLam * luong1h;
    }
}