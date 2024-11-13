#region Bài tập LT if_else 4 Tính TBC và xếp loại

//input diemToan:double, diemLy:double, diemHoa:double

//output diemTrungBinh:double, => ketQuaHocTap

//process diemTrungBinh = (diemToan + diemLy + diemHoa) / 3 

// Console.Write("Nhập vào điểm toán của bạn: ");
// double diemToan = double.Parse(Console.ReadLine());

// Console.Write("Nhập vào điểm lý của bạn: ");
// double diemLy = double.Parse(Console.ReadLine());

// Console.Write("Nhập vào điểm hóa của bạn: ");
// double diemHoa = double.Parse(Console.ReadLine());

// double diemTrungBinh = (diemToan + diemLy + diemHoa) / 3;

// Console.Write($"Với điểm trung bình của bạn là {diemTrungBinh} thì học lực của bạn là: ");

// if (diemTrungBinh >= 8.0)
// {
//     Console.Write("Học lực giỏi!");
// }
// else if (diemTrungBinh >= 6.5 && diemTrungBinh < 8.0)
// {
//     Console.Write("Học lực khá!");
// }
// else if (diemTrungBinh >= 5.0 && diemTrungBinh < 6.5)
// {
//     Console.Write("Học lực trung bình!");
// }
// else
// {
//     Console.Write("Học lực yếu!");
// }

#endregion

#region nhập vào số từ 1 tới 7 tương ứng thứ 2 đến chủ nhật

// Console.Write("Nhập số từ 1 tới 7 : ");

// int soCanKiemTra = int.Parse(Console.ReadLine());

// Console.Write($"số bạn nhập vào {soCanKiemTra} tương ứng với ");

// if (soCanKiemTra == 2)
// {
//     Console.Write("Thứ 2!");
// }
// else if (soCanKiemTra == 3)
// {
//     Console.Write("Thứ 3!");
// }
// else if (soCanKiemTra == 4)
// {
//     Console.Write("Thứ 4!");
// }
// else if (soCanKiemTra == 5)
// {
//     Console.Write("Thứ 5!");
// }
// else if (soCanKiemTra == 6)
// {
//     Console.Write("Thứ 6!");
// }
// else if (soCanKiemTra == 7)
// {
//     Console.Write("Thứ 7!");
// }
// else if (soCanKiemTra == 1)
// {
//     Console.Write("Chủ nhật!");
// }
// else
// {
//     Console.Write("Vui lòng nhập từ 1 tới 7!");
// }

#endregion

#region  sử dụng switch case giải bài toán ở trên

// Console.Write("Nhập số từ 1 tới 7 : ");

// int soCanKiemTra = int.Parse(Console.ReadLine());

// string ketQua = "";

// switch (soCanKiemTra)
// {
//     case 1:
//     {
//         ketQua = "Sunday";
//     }
//     break;

//     case 2:
//     {
//         ketQua = "Monday";
//     }
//     break;

//     case 3:
//     {
//         ketQua = "Tuesday";
//     }
//     break;

//     case 4:
//     {
//         ketQua = "Wednesday";
//     }
//     break;

//     case 5:
//     {
//         ketQua = "Thursday";
//     }
//     break;

//     case 6:
//     {
//         ketQua = "Friday";
//     }
//     break;

//     case 7:
//     {
//         ketQua = "Saturday";
//     }
//     break;
    
//     default:
//     {
//         ketQua = "Vui lòng chỉ nhập từ 1 tới 7";
//     };
//     break;

//     Console.Write($"{ketQua}");
// }
#endregion

#region sử dụng switch expression
// Console.Write("Nhập số từ 1 tới 7 : ");

// int soCanKiemTra = int.Parse(Console.ReadLine());

// string ketQua = "";

// ketQua = soCanKiemTra switch
// {
//     1 => "Sunday",
//     2 => "Monday",
//     3 => "Tuesday",
//     4 => "Wednesday",
//     5 => "Thursday",
//     6 => "Friday",
//     7 => "Saturday",
//     _ => "Không hợp lệ"
// };

// Console.Write($"{ketQua}");

#endregion

#region xây dựng chương trình quản lý điểm học sinh

// Console.Write("Nhập vào điểm số của học sinh: ");

// int diemSo = int.Parse(Console.ReadLine());

// string diemChu = "";

// diemChu = diemSo switch
// {
//     >= 90 and <= 100 => "A",
//     >= 80 and < 90 => "B",
//     >= 70 and < 80 => "C",
//     >= 60 and < 70 => "D",
//     < 60 => "F",
//     _ => "Điểm không hợp lệ"
// };

// Console.Write($"{diemChu}");


#endregion

#region Biểu thức 3 ngôi
//Bài tập mở tắt điều hòa (> 25 độ thì mở và ngược lại)

// int nhietDo = 29;

// string ketQua = nhietDo > 25 ? "Mở điều hòa" : "Tắt điều hòa" ;

#endregion