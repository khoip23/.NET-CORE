class NhanVien
{
    private static int createId = 1;
    public string? maNV;
    public string? tenNV;
    public double luongCoBan;

    //readonly: chỉ cho phép lấy giá trị bên class hoặc đối tượng
    public readonly double heSoLuong = 1;
    public double soGioLam;
    public int soNgayNghi;

    public NhanVien()
    {
        maNV = createId.ToString();
        nhapThongTinNhanVien();
        createId++;
    }

    public NhanVien(string tenNhanVien, double luong, double GioLam)
    {
        maNV = createId.ToString();
        tenNV = tenNhanVien;
        luongCoBan = luong;
        soGioLam = GioLam;
        createId++;
    }

    public void nhapThongTinNhanVien()
    {
        Console.WriteLine("Nhap ten nhan vien: ");
        tenNV = Console.ReadLine();

        Console.WriteLine("Nhap luong co ban: ");
        luongCoBan = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhap so gio lam: ");
        soGioLam = Convert.ToDouble(Console.ReadLine());
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
