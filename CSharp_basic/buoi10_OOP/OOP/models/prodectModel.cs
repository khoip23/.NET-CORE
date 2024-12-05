public class ProducModel
{
    // string? id;
    // string? name;
    // double price;

    // public void InputProductInfo()
    // {
    //     System.Console.Write("Nhập ID: ");
    //     id = Console.ReadLine();

    //     System.Console.Write("Nhập Tên sản phẩm: ");
    //     name = Console.ReadLine();

    //     System.Console.Write("Nhập giá tiền: ");
    //     price = Convert.ToDouble(Console.ReadLine());
    // }

    // public void DisLayInfo()
    // {
    //     System.Console.WriteLine($"Thông tin sản phẩm\n Mã sản phẩm: {id}\n Tên sản phẩm: {name}\n Gía tiền: {price}");
    // }

    string? maSoNhanVien;
    string? hoTenNhanVien;
    int soGioLam;
    double luong;

    public void NhapThongTinNhanVien()
    {
        System.Console.Write("Nhập mã số nhân viên: ");
        maSoNhanVien = Console.ReadLine();  

        System.Console.Write("Nhập họ tên nhân viên: ");
        hoTenNhanVien = Console.ReadLine(); 

        System.Console.Write("Nhập số giờ làm: ");
        soGioLam = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Nhập họ tiền lương trên 1 giờ: ");
        luong = Convert.ToDouble(Console.ReadLine());
    }

    private double TinhLuong()
    {
        return luong * soGioLam;
    }

    public void XuatThongTinNhanVien()
    {
        System.Console.WriteLine($"Thông tin nhân viên\n Mã số nhân viên: {maSoNhanVien}\n Họ và tên nhân viên: {hoTenNhanVien}\n Số giờ làm: {soGioLam}\n tiền lương trên 1 giờ: {luong}\n tổng lương của nhân viên này là: {TinhLuong()}");
    }
}