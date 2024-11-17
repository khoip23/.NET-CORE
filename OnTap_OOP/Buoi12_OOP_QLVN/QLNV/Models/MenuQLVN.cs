class menuQLNV
{
    public List<NhanVien> DSVN = new List<NhanVien>();
    public int Chon { get; set; }
    public menuQLNV()
    {

    }
    public void HienThiChucNang()
    {
        System.Console.WriteLine(@"
            1/ Thêm nhân viên
            2/ Tìm kiếm thông tin nhân viên dựa vào tên nhân viên (tên nhân viên không dấu)
            3/ Thay đổi tên nhân viên (khó)
            4/ Xoá nhân viên
            5/ Hiển thị danh sách thông tin nhân viên bao gồm: (mã nhân viên, tên nhân viên, lương dựa trên số giờ làm)
            6/ Thoát
        ");
    }
    public void ChonChucNang()
    {
        System.Console.Write("Nhập vào lựa chọn của bạn");
        Chon = Convert.ToInt32(Console.ReadLine());
    }
    public void ThemNhanVien()
    {
        //tạo ra 1 nhân viên mới
        NhanVien nvNew = new NhanVien();
        //Nhập thông tin nhân viên
        nvNew.NhapThongTin();
        //thêm nvNew vào list
        DSVN.Add(nvNew);
    }
    public void HienThiDanhSach()
    {
        foreach (NhanVien nv in DSVN)
        {
            nv.XuatThongTin();
        }
    }    
}