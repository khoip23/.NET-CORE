#region đảo ngược chuỗi
// string? A = Console.ReadLine();
// string ketQua = "";

//cách 1:
// for (int i = 1; i <= A.Length; i++)
// {
//     ketQua += A[^i];
// }

//cách 2:
// for (int i = A.Length -1; i <= 0; i--)
// {
//     ketQua += A[i];
// }

//cách 3:
// for (int i = 0; i < A.Length; i++)
// {
//     ketQua = s[i] = ketQua;
// }

//cách foreach
// foreach (char c in A)
// {
//     ketQua = c + ketQua;
// }

// System.Console.WriteLine(ketQua);
#endregion

#region Vòng lặp foreach (duyệt các char trên string)

// string mess = "Hello phk";

// foreach (char c in mess)
// {
//     System.Console.WriteLine(c);
// }

#endregion

#region một hàm xử lý chuỗi

// string mess = "PHAM HONG KHOI";

// string ketQua = "";
// // Chuyển tất cả kí tự của chuỗi thành kí tự thường sử dụng ToLower()
// System.Console.WriteLine($"ToLower() : {mess.ToLower()}"); 

// //ToUpper() : chuyển tất cả thành chữ thường
// System.Console.WriteLine($"ToUpper() : {mess.ToUpper()}");

// //Contain("PHAM") : kiểm tra từ PHAM có trong chuỗi hay không
// System.Console.WriteLine($"PHAM có trong chuỗi hay không: {mess.Contains("PHAM")}");

// //IndexOf("PHAM") : nhận vào 1 từ xuất hiện ở vị trí index bắt đầu từ mấy
// System.Console.WriteLine($"Vị trí (cindex) của PHAM là: {mess.IndexOf("HONG")}");

// //SubString(index_start, number) : lấy từ vị trí bắt đầu và lấy bao nhiêu phần tử
// System.Console.WriteLine($"{mess.Substring(6, 5)}"); // lấy vị trí index = 6 lấy 5 phần tử

// //Replace(tu_ban_dau, tu_muon_doi) : đổi tất cả các từ  trong chuỗi thành từ khác hết
// string mess1 = "Xin chào các bạn đã đến cybersoft";

// System.Console.WriteLine(mess1.Replace("cybersoft", "abc.com"));

// //Join("Ký tự chèn", chuỗi) : kết hợp các phần tử của mảng thành chuỗi với ký tự tự phân cách

// string mess 2 = "HELLO PHAM HONG KHOI";
// Console.WriteLine(string.Join(" ", mess2.ToArray()));

// //string.IsNullOrEmpty(srt1) : Kiểm tra chuỗi có rỗng hoặc null hay không nếu rông hoặc null thì trả về true 
// System.Console.WriteLine($"{string.IsNullOrEmpty(mess2)}");
// System.Console.WriteLine($"{string.IsNullOrEmpty("")}");
// System.Console.WriteLine($"{string.IsNullOrEmpty(null)}");

// //str.LastInDexOf('o') Tìm vị trí xuất hiện cuối cùng của kí tự ' ' trong chuỗi
// System.Console.WriteLine($"{mess.str.LastInDexOf('O')}");

#endregion

#region Tìm số nguyên tố trong khoảng 1 tới n
// //intput int n;
// System.Console.WriteLine("Nhập n:");
// int n = int.Parse(System.Console.ReadLine());

// //output string ketQua;
// string ketQua = "";

// //process:
// for (int i = 2; i <= n; i++) // vòng lặp từ 2 tới n
// {
//     //thực hiện công việc kiểm tra số có phải snt hay không?
//     //int uoc = 2;
//     bool flag = true;
//     for ( int uoc = 2; uoc <= Math.Sqrt(i); uoc ++)
//     {
//         //chia lần lượt cho ước
//         if(i % uoc == 0)
//         {
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

/*
kỹ thuật đặt cờ hiệu
- bất kỳ số tự nhiên nào cxung hiển nhiên chia hết cho 1 và chính nó,
nếu số tự nhiêu nào chia thêm được cho bất kì từ 2 tới căn bậc 2 của số đó thì đó ko phải là snt
- tạo ra biến bool flag = true; (mặc định đúng là số nguyên tố nếu sai sẽ đổi cờ sang false)
- for ( int uoc = 2; uoc <= Math.Sqrt(i); uoc ++)
    {
        //chia lần lượt cho ước
        if(i % uoc == 0)
        {
            flag = false;
            break;
        }
    }

    if (flag) //if(true)
    {
        //là số nguyên tố cộng vào chuỗi
        ketQua += $" {i}";
    }
*/

