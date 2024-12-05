#region BT1 Tính số ngày trong tuần và số ngày lẻ
// //input soNgay:int

// //output soTuan:int, soNgayLe:int;

// //process tính số tuần và ngày lẻ: (tính số tuần: soNgay / 7, tính số ngày lẻ: soNgay % 7)

// Console.Write("Nhập vào số ngày cần kiểm tra: ");

// int soNgay = int.Parse(Console.ReadLine());

// int soTuan = soNgay / 7;
// int soNgayLe = soNgay % 7;

// Console.Write($"\n{soNgay} ngày = {soTuan} tuần và {soNgayLe} ngày lẻ!!!");
#endregion

#region BT2 Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
// //input giaTriDonHang:double, phanTramGiamGia:double

// //output soTienCanThanhToan:double, soTienDuocGiam:double

// //process soTienDuocGiam =  giaTriDonHang * phanTramGiamGia, soTienCanThanhToan = giaTriDonHang - soTienDuocGiam

// Console.Write("Nhập giá trị của đơn hàng VND: ");

// double giaTriDonHang = double.Parse(Console.ReadLine());

// Console.Write("Nhập phần trăm được giảm giá: ");

// double phanTramGiamGia = double.Parse(Console.ReadLine());

// double soTienDuocGiam = giaTriDonHang * (phanTramGiamGia / 100);
// double soTienCanThanhToan = giaTriDonHang - soTienDuocGiam;

// Console.Write($"\nSố tiền được giảm giá là {soTienDuocGiam} VND!");

// Console.Write($"\nSố tiền cần thanh toán là {soTienCanThanhToan} VND!");
#endregion

#region BT3 Chuyển đổi thời gian từ phút sang giờ và phút
// //input soPhut:double

// //output soGio:double, soPhutDu:double (số phút dư)

// //process soGio = soPhut / 60; soPhutDu = soPhut % 60.

// Console.Write("Nhập vào số phút cần quy đổi: ");

// int soPhut = int.Parse(Console.ReadLine());

// int soGio = soPhut / 60;

// int soPhutDu = soPhut % 60;

// Console.Write($"\n{soPhut} được quy đổi sang giờ và phút = {soGio} giờ {soPhutDu} phút");

#endregion

#region BT4 Tính tổng số tiền sau khi cộng thêm thuế VAT
// //input soTienGoc:double, phanTramThue:double

// //output VAT:double, soTienCanThanhToan:double

// //process VAT = soTienGoc * (phanTramThue / 100), soTienCanThanhToan = soTienGoc + VAT.

// Console.Write("Nhập vào tổng số tiền của hóa đơn: ");

// double soTienGoc = double.Parse(Console.ReadLine());

// Console.Write("Nhập vào phần trăm VAT: ");

// double phanTramThue = double.Parse(Console.ReadLine());

// double VAT = soTienGoc * (phanTramThue / 100);

// double soTienCanThanhToan = soTienGoc + VAT;

// Console.Write($"\nTổng số tiền sau khi cộng thêm {VAT} VND tiền thuế là {soTienCanThanhToan}");
#endregion

#region BT5 Chuyển đổi đơn vị tiền tệ
// //input soTien:double, tyGia:double

// //output ketQua:double

// //process ketQua = soTien * tyGia.

// Console.Write("Nhập vào số USD cần quy đổi: ");

// double soTien = double.Parse(Console.ReadLine());

// double tyGia = 23000;

// double ketQua = soTien * tyGia;

// Console.Write($"{soTien} USD = {ketQua} VND");

#endregion

#region BT6 Tính số dư sau khi rút tiền từ tài khoản

// //intput nhập vào số dư tài khoản hiện tại và số tiền muốn rút soDuHienTai:int, soTienRut:int

// //output số dư còn lại sau khi rút tiền (lưu ý không kiểm tra số dư âm ở bài này)

// //process tính số dư còn lại sau khi rút tiền bằng công thức int soDuConLai = soDuHienTai - soTienRut;

// Console.Write("Nhập vào số dư hiện tại của bạn: ");
// int soDuHienTai = int.Parse(Console.ReadLine());

// Console.Write("Nhập vào số tiền bạn muốn rút: ");
// int soTienRut = int.Parse(Console.ReadLine());

// int soDuConLai = soDuHienTai - soTienRut;

// System.Console.WriteLine($"Số dư còn lại sau khi rút {soTienRut} VND còn lại {soDuConLai} VND");

#endregion

#region BT7 Tính tốc độ trung bình;
// //input nhập vào quãng đường đã đi (km) quangDuong:int, và thời gian đã đi (giờ) Time:int.

// //output tính và in ra tốc độ trung bình (km/h) tocDoTB: int.

// //process int tocDoTB = quangDuong / Time;

// Console.Write("Nhập vào quãng đường mà bạn đã đi đơn vị km:");
// int quangDuong = int.Parse(Console.ReadLine());

// Console.Write("Nhập vào thời gian để đi hết quãng đường đơn vị giờ: ");
// int Time = int.Parse(Console.ReadLine());

// int tocDoTB = quangDuong / Time;

// System.Console.WriteLine($"với quãng đường {quangDuong} Km và chạy với {Time} giờ thì ta cần chạy với tốc độ là {tocDoTB} km/h");

#endregion

#region BT8 Tính tỷ lệ phần trăm
// //input nhập vào 1 số và 1 tổng số soA:double, tongSo:double

// //out in ra tỷ lệ phần trăm của soA trong tongSo 

// //process double tyLePhamTram = (soA / tongSo) * 100;

// Console.Write("Nhập vào giá trị của số A: ");
// double soA = double.Parse(Console.ReadLine());

// Console.Write("Nhập vào giá trị của tổng số: ");
// double tongSo = double.Parse(Console.ReadLine());

// double tyLePhanTram = (soA / tongSo) * 100;

// Console.Write($"số A {soA} chiếm {tyLePhanTram} % trong tổng số {tongSo}");

#endregion

#region BT9 Chuyển đổi từ km/h sang m/s
// //input nhập vào vận tốc km/h vanToc1:double

// //output xuất ra vận tốc được quy đổi từ km/h sang m/s

// //process tốc độ được chuyển đổi theo công thức double vanToc2 = vanToc1 / 3.6

// Console.Write("Nhập vào tốc độ với đơn vị là km/h: ");
// double vanToc1 = double.Parse(Console.ReadLine());

// double vanToc2 = vanToc1 / 3.6;

// System.Console.WriteLine($"Với tốc độ là {vanToc1} km/h ta quy đổi được {vanToc2} m/s");

#endregion

#region BT10 Tính lượng calo tiêu thụ
// //input nhập vào số phút tập thể dục timeTapTheDuc:int luaChon:int, chayBo:int, dapXe:int, boiLoi:int

// //output in ra calo tiêu thự dựa trên số phút và loại hình tập thể dục

// //process sử dụng if else để lựa chọn bộ môn theo công thức (chạy bộ 10 calo mỗi phút, đạp xe là 8 calo, bơi lội là 9)

// Console.Write("Nhập vào thời gian bạn tập thể dục với đơn vị phút: ");
// int timeTapTheDuc = int.Parse(Console.ReadLine());

// Console.Write("Nhập vào lựa chọn của bạn để tính ra calo tiêu thụ: \n1: chạy bộ \n2: đạp xe \n3: bơi lội \n");
// int luaChon = int.Parse(Console.ReadLine());

// if (luaChon == 1)
// {
//     int caLoTieuThu = timeTapTheDuc * 10;
//     Console.Write($"với {timeTapTheDuc} phút chạy bộ bạn đốt được {caLoTieuThu} calo!");
// }
// else if (luaChon == 2)
// {
//     int caLoTieuThu = timeTapTheDuc * 8;
//     Console.Write($"với {timeTapTheDuc} phút đạp xe bạn đốt được {caLoTieuThu} calo!");
// }
// else if (luaChon == 3)
// {
//     int caLoTieuThu = timeTapTheDuc * 9;
//     Console.Write($"với {timeTapTheDuc} phút bơi lội bạn đốt được {caLoTieuThu} calo!");
// }
// else
// {
//     Console.Write("Vui lòng nhập đúng lựa chọn hiện có!!!");
// }

#endregion

