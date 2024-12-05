#region 
// /*
//     Ví dụ về if:
//     viết chương trình nhập vào 1 số nếu số đó là số âm thì đổi dấu
// */

// //input: number:int
// Console.Write("Nhập vào một số cần kiểm tra: ");

// int number = int.Parse(Console.ReadLine());

// //output: ketQua:int

// int ketQua = 0; //output chưa xử lý mặc định int đặt là 0.

// //process
// if (number < 0)
// {
//     ketQua = -number;
// }
// //Hiển thị kết quả ra màn hình
// Console.Write($"\nKết quả = {ketQua}");

#endregion

#region viDu_IfElse
// Console.Write("Nhập vào một số nguyên: ");

// int soNguyen = int.Parse(Console.ReadLine());

// string ketQua = "";

// if (soNguyen % 2 == 0)
// {
//     ketQua = "Số chẵn";
// }
// else
// {
//     ketQua = "Số lẻ";
// }

// Console.Write($"Số {soNguyen} là {ketQua}");

#endregion

#region BTLT1 IFELSE Viết chương trình kiểm tra 1 số nguyên do người dùng nhập vào là chẵn hay lẻ
// //input nhập và 1 số n: int

// //output xuất ra số vừa nhập và cho biết nó là chẵn hay lẻ

// //process sử dụng ifelse để kiểm tra %2 = 0 => chẵn và ngược lại

// Console.Write("Nhập vào giá trị của n: ");
// int n = int.Parse(Console.ReadLine());

// if (n % 2 == 0)
// {
//     Console.Write("giá trị bạn nhập vào là số chẵn!!!");
// }
// else
// {
//     Console.Write("giá trị bạn nhập vào là số lẻ!!!");
// }
#endregion

#region BTLT3 IFELSE Tính lương thực tế dựa trên lương cơ bản và số giờ làm việc, nếu quá 40 tính lương x1.5

// //input nhập vào lương cơ bản luongCoBan: double, giờ làm việc gioLamViec: double.

// //output xuất ra lương thực tế luongThucTe: double

// //process tính ra lương thực tế luongThucTe = gioLamViec * luongCoBan; nếu quá 40 giờ luongThucTe = gioLamViec * (luongCoBan * 1.5);


// Console.Write("Nhập vào giờ bạn đã làm việc: ");
// double gioLamViec = double.Parse(Console.ReadLine());

// Console.Write("Nhập vào lương cơ bản của bạn: ");
// double luongCoBan = double.Parse(Console.ReadLine());

// double luongThucTe = 0;

// if (gioLamViec <= 40)
// {
//     luongThucTe = gioLamViec * luongCoBan;
//     Console.Write($"Lương thực tế của bạn là {luongThucTe} vnd");
// }
// else
// {
//     luongThucTe = gioLamViec * (luongCoBan * 1.5);
//     Console.Write($"Lương thực tế của bạn là {luongThucTe} vnd");
// }
#endregion



