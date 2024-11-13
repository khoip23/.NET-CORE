public class NhanVien
{
    public string? maNhanVien;
    public string? tenNhanVien;
    public double soGioLam;
    public double luong1H;
    public void nhapThongTinNhanVien()
    {
        System.Console.WriteLine("Nhập mã nhân viên:");
        maNhanVien = Console.ReadLine();

        System.Console.WriteLine("Nhập tên nhân viên:");
        tenNhanVien = Console.ReadLine();

        System.Console.WriteLine("Nhập số giờ làm:");
        soGioLam = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Nhập tiền lương của 1 giờ:");
        luong1H = Convert.ToDouble(Console.ReadLine());
    }

    public void xuatThongTinNhanVien()
    {
        System.Console.WriteLine($"Thông tin nhân viên: \nMã nhân viên: {maNhanVien} \nTên nhân viên: {tenNhanVien} \nSố giờ làm: {soGioLam} \nTiền lương 1 giờ: {luong1H}\n Tổng tiền lương: {tongTienLuong()} ");
    }

    private double tongTienLuong()
    {
        double tongTienLuongNhanVien = 0;
        tongTienLuongNhanVien = soGioLam * luong1H;
        return tongTienLuongNhanVien;
    }
}