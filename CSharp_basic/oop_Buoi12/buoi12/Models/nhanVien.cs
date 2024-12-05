class NhanVien {
    public static int idNhanVien = 1;//Tất cả nhân viên
    public int MaNhanVien {get;set;} //1 đối tượng nhân viên được tạo ra từ class
    public string? HoTen {get;set;} = "";
    public double Luong1h {get;set;}
    public double SoGioLam {get;set;}
    public NhanVien(){
        NhapThongTin();
    }
    public void NhapThongTin(){
        MaNhanVien = idNhanVien;
        Console.Write("Nhập vào họ tên: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhập vào Lương 1h:");
        Luong1h = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập vào số giờ làm:");
        SoGioLam = Convert.ToDouble(Console.ReadLine());
        //Thuộc tính của class không phải của đối tượng được new từ NhanVien
        NhanVien.idNhanVien ++;
    }
    public void XuatThongTin(){
        Console.WriteLine(@$"
            --------- Thông tin nhân viên: {HoTen} -------------
            Mã số: {MaNhanVien}
            Họ tên: {HoTen}
            Lương 1h : {Luong1h}
            Lương: {TinhLuong()} Làm : {SoGioLam}
        ");
    }
    private double TinhLuong(){
        return SoGioLam * Luong1h;
    }

}