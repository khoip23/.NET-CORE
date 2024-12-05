internal class Program
{
    /*
    public: có thể truy xuất thuộc tính hoặc phươn thức
    đó ở bất kì đâu
    (trong class, trên đối tượng)
    private: chỉ có thể truy xuất bên trong class
    get: cho phép láy giá trị
    set: cho phép gán giá trị
    private get: chỉ đợc lấy bên phía đối tượng (public)
    private set: chỉ đợc gán bên phía đối tượng (public)

    readonly: là thuộc tính chỉ có thể đọc(không thể set giá trị)

    overloading method: là các method trong 1 class
    có thể trùng tên
    (tuy nhiên khác số lượng tham số hoặc khác dữ liệu truyền
    vào của các tham số)
    */
    private static void Main(string[] args)
    {
        // NhanVien nv = new NhanVien();

        // nv.nhapThongTinSinhVien();
        // nv.tinhLuong();
        // nv.xuatThongTinNhanVien();

        NhanVien nv2 = new NhanVien(true);
        
        nv2.xuatThongTinNhanVien();
        // nv2.maNhanVien = "1";
        // nv2.tenNhanVien = "khoi";
        // nv2.soGioLam = 8;
        // nv2.luongCoBan = 1000;
        // nv2.heSoLuong = 1;
        // nv2.xuatThongTinNhanVien();

        NhanVien.disPlayInfo();

        NhanVien nv3 = new NhanVien("3", "khôi phạm", 1000, 10);
        nv3.xuatThongTinNhanVien();


    }
}