internal class Program
{
    private static void Main(string[] args)
    {
        // ProducModel prd = new ProducModel();
        // prd.InputProductInfo();
        // prd.DisLayInfo();

        //viết chương trình cho phép người dùng nhập vào: mã nhân viên, họ tên, số giờ làm, lương tren 1 giờ, yêu cầu tính lương nhân viên đó và hiển thị thong tin nhân viên kèm theo lương
        //phân tích lớp đối tượng(thuộc tính, phương thức) => sơ đồ class diagram

        ProducModel nhanVien1 = new ProducModel();
        nhanVien1.NhapThongTinNhanVien();
        nhanVien1.XuatThongTinNhanVien();

        ProducModel nhanVien2 = new ProducModel();
        nhanVien2.NhapThongTinNhanVien();
        nhanVien2.XuatThongTinNhanVien();
    }
}