#region BT1 Kiểm tra số âm dương hoặc bằng 0

// Console.Write("Nhập vào 1 số nguyên dương: ");
// int n = int.Parse(Console.ReadLine());

// if (n % 2 == 0)
// {
//     Console.WriteLine("Số n là số dương");
// }
// else if (n % 2 == 1)
// {
//     Console.Write("Số n là số lẻ");
// }
// else
// {
//     Console.WriteLine("Số bạn nhập vào là số 0!!!");
// }

#endregion

#region BT2 Tính thuế thu nhập cá nhân 

// //input nhập vào mức thu nhập cá nhân thuNhap: double, 

// //output xuất ra mức thuế dựa theo thu nhập của bạn 
// //thu nhập <= 5m miễn thuế, <= 10m thuế 10%, > 10m thuế 20%

// //process sử dụng if else để kiểm tra

// Console.Write("Nhập vào thu nhập của bạn: ");
// double thuNhap = double.Parse(Console.ReadLine());

// double thue = 0.0;

// if (thuNhap < 5000000)
// {
//     Console.WriteLine("Bạn được miễn thuế!!!");
// }
// else if (thuNhap <= 10000000 && thuNhap >= 5000000)
// {
//     thue = thuNhap * 0.1;
//     System.Console.WriteLine($"Thuế của bạn là 10% tương đương {thue}");
// }
// else
// {
//     thue = thuNhap * 0.2;
//     Console.WriteLine($"Thuế của bạn là 20% tương đương {thue}");
// }

#endregion

#region BT3 Xác định mùa trong năm
// //sử dụng switch expression

// Console.Write("Nhập vào 1 số trong khoản 1 tới 12: ");
// int numBer = int.Parse(Console.ReadLine());

// string ketQua = "";

// ketQua = numBer switch
// {
//     1 => "Mùa xuân",
//     2 => "Mùa xuân",
//     3 => "Mùa xuân",
//     4 => "Mùa hạ",
//     5 => "Mùa hạ",
//     6 => "Mùa hạ",
//     7 => "Mùa thu",
//     8 => "Mùa thu",
//     9 => "Mùa thu",
//     10 => "Mùa đông",
//     11 => "Mùa đông",
//     12 => "Mùa đông",
//     _ => "Không hợp lệ!!!"
// };

// System.Console.WriteLine($"giá trị bạn nhập tương ứng với {ketQua}");

#endregion

#region BT4 Kiểm tra tuổi và phân loại
// //input nhập vào số tuổi 
// //output xuất ra xếp loại dựa trên số tuổi
// // < 18 : trẻ em, > 18 < 60: người lớn, > 60: người cao tuổi
// //process sử dụng if else để phân loại

// Console.Write("Nhập vào độ tuổi cần xếp loại: ");
// int doTuoi = int.Parse(Console.ReadLine());

// if (doTuoi < 18)
// {
//     Console.WriteLine("Trẻ em");
// }
// else if (doTuoi >= 18 && doTuoi < 60)
// {
//     Console.Write("Người lớn");
// }
// else
// {
//     Console.WriteLine("Người cao tuổi");
// }

#endregion

#region BT6 Tính tiền điện
// //input nhập vào số điện đã tiêu thụ tieuThuDien: double
// //output xuất ra tiền điện theo tỷ lệ quy định
// //process sử dụng if else để tính
// // < 100 kWh : 1500 VND / kWh
// // >= 100 && <= 200 : 2000 VND / kWh
// // > 200 : 2500 VND / kWh

// Console.Write("Nhập vào số điện đã tiêu thụ: ");
// double tieuThuDien = double.Parse(Console.ReadLine());

// double tienDien = 0.0;

// if (tieuThuDien < 100)
// {
//     tienDien = tieuThuDien * 1500;
//     System.Console.WriteLine($"Với mức tiêu thụ điện là {tieuThuDien} kWh thì tiền điện cần trả là {tienDien} VND");
// }
// else if (tieuThuDien >= 100 && tieuThuDien <= 200)
// {
//     tienDien = tieuThuDien * 2000;
//     System.Console.WriteLine($"Với mức tiêu thụ điện là {tieuThuDien} kWh thì tiền điện cần trả là {tienDien} VND");
// }
// else
// {
//     tienDien = tieuThuDien * 2500;
//     System.Console.WriteLine($"Với mức tiêu thụ điện là {tieuThuDien} kWh thì tiền điện cần trả là {tienDien} VND");
// }

#endregion

#region BT7 Xác định hạng vé xem phim
// //input nhập vào hạng vé xem film 
// //output xuất ra hạng vé tương đương
// //process sử dụng switch expression

// Console.Write("Nhập vào hạng vé của bạn: ");
// int nhapHangVe = int.Parse(Console.ReadLine());

// string? hangVe = "";

// hangVe  = nhapHangVe switch
// {
//     1 => "Ghế ngồi thường không có đồ uống",
//     2 => "Ghế ngồi thoải mái có đồ uống miễn phí",
//     3 => "Ghế ngồi hạng sang có đồ uống và bỏng ngô miễn phí",
//     _ => "Bạn chưa có vé hoặc tên hạng vé sai!!!"
// };

// System.Console.WriteLine($"Hạng vé của bạn sẽ có {hangVe}");

#endregion

#region BT8 Tính tiền taxi
//input nhập vào km khách hàng đã đi quangDuong:int
//out xuất ra số tiền khách hàn phải trả

// Console.Write("Nhập vào quãng đường đã đi của khách hàng đơn vị Km: ");
// int quangDuong = int.Parse(Console.ReadLine());

// int giaTien = 0;

// if (quangDuong == 1)
// {
//     Console.WriteLine("Số tiền cần trả là 10000 VND");
// }
// else if (quangDuong >= 2 && quangDuong <= 5)
// {
//     giaTien = 10000 + (quangDuong - 1) * 8000;
//     Console.WriteLine($"số tiền cần trả là {giaTien}");
// }
// else
// {
//     //10000: 1km đầu tiên.  32000: 4km tiếp theo
//     giaTien = 10000 + 32000 + quangDuong * 6000;
//     Console.WriteLine($"số tiền cần trả là {giaTien}");
// }
#endregion

#region BT9 Kiểm tra nguyên âm hoặc phụ âm 
//input nhập vào 1 chữ cái
//output xác định nguyên âm hay phụ âm/
//process sử dụng switch expression

// Console.Write("Nhập vào một chữ cái: ");
// string a = Console.ReadLine();

// string ketQua = "";

// ketQua = a switch
// {
//     "u" => "u là nguyên âm",
//     "e" => "e là nguyên âm",
//     "o" => "0 là nguyên âm",
//     "a" => "a là nguyên âm",
//     "i" => "i là nguyên âm",
//     _ => "chữ cái bạn nhập là phụ âm"
// };

// System.Console.WriteLine($"Chữ cái bạn nhập vào là {ketQua}");

#endregion

#region BT10 Xác định loại vé máy bay

// Console.Write("Nhập vào loại vé của bạn: ");
// string loaiVe = Console.ReadLine();

// string ketQua = "";

// ketQua = loaiVe switch
// {
//     "Economy" => "Ghế thường",
//     "Business" => "Ghế rộng",
//     "First Class" => "Ghế sang trọng",
//     _ => "Lỗi!!!!!!!!!!!!!"
// };

// System.Console.WriteLine($"Loại vé bạn đặt có ghế là loại {ketQua}");

#endregion

