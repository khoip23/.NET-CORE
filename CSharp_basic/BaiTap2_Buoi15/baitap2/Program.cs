class Program
{
    static void Main(string[] args)
    {
        QuanLySanPham qlsp = new QuanLySanPham();
        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính tổng doanh thu");
            Console.WriteLine("4. Xóa sản phẩm");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.WriteLine("\nChọn loại sản phẩm:");
                    Console.WriteLine("1. Điện tử");
                    Console.WriteLine("2. Thời trang");
                    Console.WriteLine("3. Thực phẩm");
                    int loai = int.Parse(Console.ReadLine());

                    Console.Write("Nhập mã sản phẩm: ");
                    string ma = Console.ReadLine();
                    Console.Write("Nhập tên sản phẩm: ");
                    string ten = Console.ReadLine();
                    Console.Write("Nhập giá gốc: ");
                    double giaGoc = double.Parse(Console.ReadLine());

                    if (loai == 1)
                    {
                        Console.Write("Nhập thuế bảo hành: ");
                        double thue = double.Parse(Console.ReadLine());
                        qlsp.ThemSanPham(new DienTu(ma, ten, giaGoc, thue));
                    }
                    else if (loai == 2)
                    {
                        Console.Write("Nhập giảm giá theo mùa: ");
                        double giamGia = double.Parse(Console.ReadLine());
                        qlsp.ThemSanPham(new ThoiTrang(ma, ten, giaGoc, giamGia));
                    }
                    else if (loai == 3)
                    {
                        Console.Write("Nhập phí vận chuyển: ");
                        double phiVC = double.Parse(Console.ReadLine());
                        qlsp.ThemSanPham(new ThucPham(ma, ten, giaGoc, phiVC));
                    }
                    break;

                case 2:
                    qlsp.HienThiDanhSachSanPham();
                    break;

                case 3:
                    Console.WriteLine($"Tổng doanh thu dự kiến: {qlsp.TinhTongDoanhThu()}");
                    break;

                case 4:
                    Console.Write("Nhập mã sản phẩm cần xóa: ");
                    string maXoa = Console.ReadLine();
                    qlsp.XoaSanPham(maXoa);
                    break;

                case 5:
                    Console.WriteLine("Thoát chương trình.");
                    return;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
