public class NhanVien
{

    //static thuộc class chứ không thuộc instance
    //(object đợc tạo ra từ class)
    public string? maNhanVien{ get;set; }
    public string? tenNhanVien{ get;set; }


    public double luongCoBan{ get;set; }


    public double soGioLam{ get;set; }


    public double heSoLuong { get;set; } = 1;

    // public NhanVien() //hàm khởi tạo(constructor)
    // {
    //     nhapThongTinSinhVien();
    // }

    public NhanVien()
    {
        System.Console.WriteLine("Hàm khởi tạo mặc định");
    }

    public NhanVien(bool input = false) //hàm khởi tạo có tham số(constructor)
    {
        if (input)
        {
            nhapThongTinSinhVien();
        }
    }

    public NhanVien(string maNV, string tenNV, double luong, double GioLam )
    {
        maNhanVien = maNV;
        tenNhanVien = tenNV;
        luongCoBan = luong;
        soGioLam = GioLam;

    }

    public void nhapThongTinSinhVien()
    {
        System.Console.WriteLine("Nhập mã nv:");
        maNhanVien = Console.ReadLine();
        
        System.Console.WriteLine("Nhập tên nv:");
        tenNhanVien = Console.ReadLine();

        System.Console.WriteLine("Nhập lương cơ bản:");
        luongCoBan = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Nhập số giờ làm:");
        soGioLam = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Nhập hệ số lương:");
        heSoLuong = Convert.ToDouble(Console.ReadLine());
    }

    public double tinhLuong()
    {

        return luongCoBan * soGioLam * heSoLuong;
    }

    public void xuatThongTinNhanVien()
    {
        System.Console.WriteLine($@"
            Mã nhân viên: {maNhanVien}
            Tên nhân viên: {tenNhanVien}
            Tổng lương: {tinhLuong()}
        
        ");
    }

    //static method không thuộc về đối tượng chỉ thuộc về class

    public static void disPlayInfo()
    {
        System.Console.WriteLine("Class nv ver: 1.0.0");
    }
}