class NhanVien
{
    public string? maNV;
    public string? tenNV;
    public double luongCoBan;

    //readonly: chỉ cho phép lấy giá trị bên class hoặc đối tượng
    public readonly double heSoLuong = 1;
    public double soGioLam;
    public int soNgayNghi;

    public NhanVien()
    {
        soNgayNghi = 10;
        nhapThongTinNhanVien();
    }

    public NhanVien(string maNhanVien, string tenNhanVien, double luong, double GioLam)
    {
        maNV = maNhanVien;
        tenNV = tenNhanVien;
        luongCoBan = luong;
        soGioLam = GioLam;
    }

    public void nhapThongTinNhanVien()
    {
        Console.WriteLine("Nhap ma nhan vien: ");
        maNV = Console.ReadLine();

        Console.WriteLine("Nhap ten nhan vien: ");
        tenNV = Console.ReadLine();

        Console.WriteLine("Nhap luong co ban: ");
        luongCoBan = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap so gio lam: ");
        soGioLam = double.Parse(Console.ReadLine());
    }

    public double tinhLuong()
    {
        return luongCoBan * soGioLam * heSoLuong;
    }

    public void xuatThongTinNhanVien()
    {
        Console.WriteLine(
            @$"
            Mã nhân viên: {maNV}
            Tên nhân viên: {tenNV}
            Lương cơ bản: {luongCoBan}
            Số giờ làm: {soGioLam}
        "
        );
    }
}
