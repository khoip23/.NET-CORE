NhanVien nv = new NhanVien();
nv.tenNV = "Nguyen Van A";
nv.xuatThongTinNhanVien();
Console.WriteLine($"Lương: {nv.tinhLuong()} ");

NhanVien nv1 = new NhanVien("PhamKhoi", 100000, 20);
nv1.xuatThongTinNhanVien();
Console.WriteLine($"Lương: {nv1.tinhLuong()} ");
