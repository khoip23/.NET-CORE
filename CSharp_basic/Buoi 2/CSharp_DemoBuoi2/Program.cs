#region Bài tập 1
// //Viết chương trình cho người dùng nhập vào độ C để tính ra độ F tương ứng với công thức
// using System.Net.NetworkInformation;

// Console.Write("Vui lòng nhập số nhiệt độ C cần quy đổi: ");

// int doC;

// doC = int.Parse(Console.ReadLine());

// int doF = doC * 9 /5 + 32;

// Console.WriteLine($"Nhiệt độ vừa nhập là {doC} độ C = {doF} độ F");

#endregion

#region Bài tập 2
// //input: bankinh:double, pi:double
// Console.Write("Nhập vào bán kính của hình tròn: ");

// double banKinh = double.Parse(Console.ReadLine());

// const double pi = Math.PI;

// //output: chuvi:double, dientich:double
// double dienTich = pi * Math.Pow(banKinh,2);
// double chuVi = 2 * pi * banKinh;

// Console.Write($"Chu vi của hình tròn 2 * pi * banKinh\n Chu vi = {chuVi}");

// Console.Write($"\nDiện tích của hình tròn pi * banKinh ^ 2\n Diện tích = {dienTich}");

#endregion

#region Bài tập 3
// //input canNang:double, chieuCao:double
// Console.Write("Nhập vào cân nặng của bạn: ");

// double canNang = double.Parse(Console.ReadLine());

// Console.Write("Nhập vào chiều cao của bạn: ");

// double chieuCao = double.Parse(Console.ReadLine());

// //output chiSoBMI:double

// double chiSoBMI = canNang / Math.Pow(chieuCao,2);

// Console.Write($"\nChỉ số BMI của bạn sau khi được tính theo công thức cân nặng / chiều cao ^ 2 \n BMI = {chiSoBMI}");

#endregion

#region Bài tập LT1 (Tính số tuần và ngày lẻ)

// input soNgay:int

// output soTuan:int, soNgayLe:int;

// process tính số tuần và ngày lẻ: (tính số tuần: soNgay / 7, tính số ngày lẻ: soNgay % 7)

// Console.Write("Nhập vào số ngày cần kiểm tra: ");

// int soNgay = int.Parse(Console.ReadLine());

// int soTuan = soNgay / 7;
// int soNgayLe = soNgay % 7;

// Console.Write($"\n{soNgay} ngày = {soTuan} tuần và {soNgayLe} ngày lẻ!!!");

#endregion

#region Bài tập LT2 (Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá) 

//input giaTriDonHang:double, phanTramGiamGia:double

//output soTienCanThanhToan:double, soTienDuocGiam:double

//process soTienDuocGiam =  giaTriDonHang * phanTramGiamGia, soTienCanThanhToan = giaTriDonHang - soTienDuocGiam

// Console.Write("Nhập giá trị của đơn hàng VND: ");

// double giaTriDonHang = double.Parse(Console.ReadLine());

// Console.Write("Nhập phần trăm được giảm giá: ");

// double phanTramGiamGia = double.Parse(Console.ReadLine());

// double soTienDuocGiam = giaTriDonHang * (phanTramGiamGia / 100);
// double soTienCanThanhToan = giaTriDonHang - soTienDuocGiam;

// Console.Write($"\nSố tiền được giảm giá là {soTienDuocGiam} VND!");

// Console.Write($"\nSố tiền cần thanh toán là {soTienCanThanhToan} VND!");

#endregion

#region Bài tập LT3 (Chuyển đổi thời gian từ phút sang giờ và phút)

// //input soPhut:double

// //output soGio:double, soPhutDu:double (số phút dư)

// //process soGio = soPhut / 60; soPhutDu = soPhut % 60.

// Console.Write("Nhập vào số phút cần quy đổi: ");

// int soPhut = int.Parse(Console.ReadLine());

// int soGio = soPhut / 60;

// int soPhutDu = soPhut % 60;

// Console.Write($"\n{soPhut} được quy đổi sang giờ và phút = {soGio} giờ {soPhutDu} phút");

#endregion

#region Bài tập LT4 (Tính tổng số tiền sau khi cộng thêm thuế VAT)

//input soTienGoc:double, phanTramThue:double

//output VAT:double, soTienCanThanhToan:double

//process VAT = soTienGoc * (phanTramThue / 100), soTienCanThanhToan = soTienGoc + VAT.

// Console.Write("Nhập vào tổng số tiền của hóa đơn: ");

// double soTienGoc = double.Parse(Console.ReadLine());

// Console.Write("Nhập vào phần trăm VAT: ");

// double phanTramThue = double.Parse(Console.ReadLine());

// double VAT = soTienGoc * (phanTramThue / 100);

// double soTienCanThanhToan = soTienGoc + VAT;

// Console.Write($"\nTổng số tiền sau khi cộng thêm {VAT} VND tiền thuế là {soTienCanThanhToan}");

#endregion

#region Bài tập LT5 (Chuyển đổi đơn vị tiền tệ)

//input soTien:double, tyGia:double

//output ketQua:double

//process ketQua = soTien * tyGia.

// Console.Write("Nhập vào số USD cần quy đổi: ");

// double soTien = double.Parse(Console.ReadLine());

// double tyGia = 23000;

// double ketQua = soTien * tyGia;

// Console.Write($"{soTien} USD = {ketQua} VND");
#endregion

