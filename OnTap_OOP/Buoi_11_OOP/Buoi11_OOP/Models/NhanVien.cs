public class NhanVien
{
    private static int createID = 1;
    private static double ver = 1.0;
    private static string name = "Class NhanVien";

    public string? maNhanVien;
    public string? tenNhanVien;
    public double soGioLam;
    public double luong1H { get; set; } = 100;

    public int soNgayNghi;

    public NhanVien()
    {
        maNhanVien = createID.ToString();
        nhapThongTinNhanVien();
        createID++;
    }

    public NhanVien(string tenNV, double luong, double gioLam)
    {
        maNhanVien = createID.ToString();
        tenNhanVien = tenNV;
        luong1H = luong;
        soGioLam = gioLam;
        createID++;
    }

    public void nhapThongTinNhanVien()
    {
        System.Console.WriteLine("Nhập tên nhân viên: ");
        tenNhanVien = Console.ReadLine();
        System.Console.WriteLine("Nhập số giờ làm: ");
        soGioLam = Convert.ToDouble(Console.ReadLine());
    }

    private double tinhLuong()
    {
        return luong1H * soGioLam;
    }
    public void xuatThongTinNhanVien()
    {
        System.Console.WriteLine(@$"
            Mã nhân viên: {maNhanVien}
            Tên nhân viên: {tenNhanVien}
            Số giờ làm: {soGioLam}
            Lương 1 giờ: {luong1H} 
            Tổng tiền lương: {tinhLuong()}        
        ");
    }

    public static void ShowversionNhanVien()
    {
        System.Console.WriteLine($@"
            Classname: {name}
            version: {ver}        
        ");
    }
}