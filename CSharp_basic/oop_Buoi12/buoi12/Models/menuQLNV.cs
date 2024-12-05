using System.Text.Json //Để biến object thành string định dang json

class MenuQLNV {
    public List<NhanVien> DSNV = new List<NhanVien>();
    public int Chon {get;set;}
    public MenuQLNV(){

    }
    public void HienThiChucNang(){
        Console.WriteLine(@"
            1/ Thêm nhân viên
            2/ Tìm kiếm thông tin nhân viên dựa vào tên nhân viên (tên nhân viên không dấu)
            3/ Thay đổi tên nhân viên (khó)
            4/ Xoá nhân viên
            5/ Hiển thị danh sách thông tin nhân viên bao gồm: (mã nhân viên, tên nhân viên, lương dựa trên số giờ làm)
            6/ Lưu file
            7/ Load file
            8/ Thoát
        ");
    }
    public void ThemNhanVien () {
        //Tạo ra 1 nhân viên
        NhanVien nvNew = new NhanVien();
        //Nhập thông tin
        nvNew.NhapThongTin();
        //Thêm vào List 
        DSNV.Add(nvNew);
    }
    public void HienThiDanhSach() {
        foreach(NhanVien nv in DSNV){
            nv.XuatThongTin();
        }
    }

    public void LuuDSNV()
    {
        string sDSNV = JsonSerializerSerialize(this.DSNV);
        //Lưu dữ liệu string danh sach nhân viên vào file
        await File.WriteAlltestAsync("DSNV.Json",sDSNV)
    }

    public async void LoadDSNV() {
        //Đọc text (string) từ file 
        string strDSNV =  await File.ReadAllTextAsync("./DSNV.json");
        //Chuyển đổi text thành Object theo định dạng muốn chuyển
        this.DSNV = JsonSerializer.Deserialize<List<NhanVien>>(strDSNV);


    }

}