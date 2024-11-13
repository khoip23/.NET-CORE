class GiangVien : NguoiDung
{
    public List<string> CacLopGiangDay = new List<string>();

    public GiangVien(string mail, string pass) : base(mail, pass)
    {
        
    }

    public override bool DangNhap()
    {
        base.DangNhap();
        System.Console.WriteLine("Chào mừng giảng viên đã đăng nhập thành công");
        return true;
    }
    public void TaoBaiTap()
    {
        System.Console.WriteLine("Tạo bài tập");
    }

    public void ChamBai()
    {
        System.Console.WriteLine("Chấm bài");
    }
}