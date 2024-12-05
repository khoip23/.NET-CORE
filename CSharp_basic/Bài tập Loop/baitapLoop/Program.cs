#region BT1 Tính tổng các số từ 1 -> n

// Console.Write("Nhập vào n: ");
// int n = int.Parse(Console.ReadLine());

// int sum = 0;

// for (int i = 1; i <= n; i++)
// {
//     sum += i;
// }

// System.Console.WriteLine($"Tổng các số từ 1 tới n = {sum}");

#endregion

#region BT2 Tính tổng các số từ 2 -> 2n

// Console.Write("Nhập vào n: ");
// int n = int.Parse(Console.ReadLine());

// int sum = 0;

// for (int i = 1; i <= n; i++)
// {
//     if (i % 2 == 0)
//     {
//         sum += i;
//     }
// }

// System.Console.WriteLine($"Tổng các số chẵn từ 1 -> n = {sum}");

#endregion

#region BT3 Tính giai thừa

// Console.Write("Nhập số giai thừa n: ");
// int n = int.Parse(Console.ReadLine());

// int giaiThua = 1; 

// for (int i = 1; i <= n; i++)
// {
//     giaiThua *= i;
// }

// System.Console.WriteLine($"Kết quả của {n}! = {giaiThua}");
#endregion

#region BT4 Tính tổng bình phương các số từ 1 -> n

// Console.Write("Nhập n: ");
// int n = int.Parse(System.Console.ReadLine());



#endregion

#region BT5 Kiểm tra số nguyên tố

// Console.Write("Nhập n: ");
// int n = int.Parse(System.Console.ReadLine());

// string ketLuan = "";

// int soHang = 1; // giá trị điều kiện
// int soUoc = 0; //biến cờ hiệu

// while (soHang <= n) // điều kiện lặp: số hạng chạy từ 1 -> n
// {
//     if (n % soHang == 0) //nếu n
//     {
//         soUoc ++;
//     }
//     //thay đổi số hạng
//     soHang ++;
// }

// if (soUoc == 2)
// {
//     ketLuan = $"{n} là số nguyên tố"
// }
// else
// {
//     ketLuan = $"{n} không phải là số nguyên tố"
// }

// //in kết quả
// System.Console.Write(ketLuan);

#endregion

#region 
// System.Console.WriteLine("Nhập n: ");

// int n = int.Parse(System.Console.ReadLine());

// int biendem = 0;

// for (int i = 1; i <= n; i++)
// {
//     if (n % i == 0)
//     {
//         biendem++;
//     }
// }

// if (biendem == 2)
// {
//     System.Console.WriteLine("SNT");
// }
// else
// {
//     System.Console.WriteLine("0SNT");
// }
#endregion

#region Tìm số nguyên tố trong khoảng từ 1 đến số người dùng nhập vào

// //input int n
// System.Console.WriteLine("nhập vào n: ");
// int n = int.Parse(Console.ReadLine());

// //output ketQua:string
// string ketQua = "";

// //process
// for (int i = 2; i <= n; i++) // vòng lặp duyệt từ 2 tới n
// {
//     //thực hiện công việc: kiểm tra số i có phải số nguyên tố hay không
//     bool flag = true;

//     for (int uoc = 2; uoc <= Math.Sqrt(i); uoc++)
//     {
//         //chia số cho ước lần lượt
//         if (i % uoc == 0)
//         {
//             //đã nhiều hơn 2 ước
//             flag = false;
//             break;
//         }
//     }
//     if (flag)
//     {
//         ketQua += $" {i}";
//     }
    

// }

// System.Console.WriteLine(ketQua);

#endregion