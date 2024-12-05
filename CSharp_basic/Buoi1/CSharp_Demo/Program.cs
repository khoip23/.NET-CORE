Console.WriteLine("Nhap vao ho ten cua ban: ");

string? hoTen = Console.ReadLine(); //dấu chấm hỏi để dòng lệnh chấp nhận giá trị null (null là rỗng)

Console.WriteLine($"Họ Tên của bạn là: {hoTen}");

int soA = 5;
int soB = 10;

Console.WriteLine($"Sum a + b = {soA + soB}");

//Phép tiền tố, hậu tố (tiền tố là tăng hoặc giảm trước rồi mới thực hiện lệnh lớn sau, hậu tố ngược lại)
Console.WriteLine($"Sau khi +1 soA = {++soA}");

//tăng n giá trị cho soA
soA += 10;
Console.WriteLine($"soA + 10 = {soA}");

//Viết chương trình nhập vào số điện thoại của bạn
Console.WriteLine("Hãy nhập vào số điện thoại của bạn");

string soDT = null ?? "Chưa nhập số điện thoại";

Console.WriteLine($"Số điện thoại của bạn: {soDT}");

/*Chuyển đổi kiểu dữ liệu*/

string a = "10";
string b = "20";
int ketQua = int.Parse(a) + int.Parse(b);

Console.WriteLine($"a + b = {ketQua}");
//cách 2
int ketQua1 = Convert.ToInt32(a) + Convert.ToInt32(b);

Console.WriteLine($"a + b = {ketQua1}");

/*Tính trung bình cộng*/

Console.WriteLine("Cho người nhập vào 2 số");

int soThu1, soThu2;

Console.Write("Nhập vào số thứ 1: ");
soThu1 = int.Parse(Console.ReadLine());

Console.Write("Nhập vào số thứ 2: ");
soThu2 = int.Parse(Console.ReadLine());

int TBC = (soThu1 + soThu2) / 2;
Console.WriteLine($"trung bình cộng của 2 số vừa nhập là: (soThu1 + soThu2) / 2 = {TBC} ");


