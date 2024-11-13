//Lớp cơ sở (base class): Chứa các thuộc tính và phương thức dùng chung cho các class dẫn xuất
class NguoiDung {
    public string Email {get;set;} = "";
    public string UserName {get;set;} = "";
    public string HoTen {get;set;} = "";
    public string MatKhau {get;set;} = "";
    public string SoDienThoai {get;set;} = "";
    public string SoDienThoai {get;set;} = "";

    public NguoiDung(string mail, string pass)
    {
        this.Email = mail;
        this.MatKhau = pass;
    }
    public virtual bool DangNhap(){
        Console.Write("Đăng nhập thành công!");
        return true;
    }
     public bool DangXuat(){
        Console.Write("Đăng xuất thành công!");
        return true;
    }
 
}