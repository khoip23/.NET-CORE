// #region  Lý thuyết về list
// // //cú pháp khai báo list
// // List<string> danhSachTenHocVien = new List<string>() {"Khoi", "Hanh", "Hop", "Khoi", "Khoi", "Khoi"};
// // //                                              INDEX    0       1       2
// // //                                        preINDEX       ^3      ^2      ^1
// // //                                       Count(lengt):   4 
// // //LIST: CRUD (creat - insert, read, update, delete)


// // //sử dụng hàm Join để gọi list 
// // System.Console.WriteLine(string.Join(",", danhSachTenHocVien));

// // /*-------------------------------Read (đọc | duyệt | tìm kiếm)-----------------------------------------*/

// // // lấy ra 1 phần từ: lst[index]
// // System.Console.WriteLine(danhSachTenHocVien[1]);

// // //cách 2
// // System.Console.WriteLine(danhSachTenHocVien.ElementAt(^3));

// // System.Console.WriteLine(danhSachTenHocVien.ElementAt(^danhSachTenHocVien.Count));

// // //Duyệt List:
// // for (int index = 0; index < danhSachTenHocVien.Count; index++)
// // {
// //     System.Console.WriteLine($"Phần tử {index} = {danhSachTenHocVien[index]}");
// // }

// // foreach(string tenBien in danhSachTenHocVien)
// // {
// //     System.Console.WriteLine($"Tên học viên: {tenBien}");
// // }

// // List<int> giaTien = new List<int>{ 10000, 2000, 300, 4050, 500};


// // //.Sort() : hàm có sẵn của list hỗ trợ sắp xếp phần tử
// // //Sort int : từ nhỏ đến lớn
// // giaTien.Sort();
// // System.Console.WriteLine($"sắp xếp {string.Join(",", giaTien)}");

// // //.Sort string: A - Z
// // danhSachTenHocVien.Sort();
// // System.Console.WriteLine($"{string.Join(",", danhSachTenHocVien)}");

// // //.Reverse() : hàm đảo ngược các phần tử 
// // giaTien.Reverse();
// // System.Console.WriteLine($"{string.Join(",", giaTien)}");

// // danhSachTenHocVien.Reverse();
// // System.Console.WriteLine($"{string.Join(",", danhSachTenHocVien)}");

// // //Tìm kiếm phần tử trong list: kỹ thuật đặt cờ (tìm kiếm chỉnh sửa đều phải duyệt qua list)
// // int indexFind = -1;
// // for (int index = 0; index < danhSachTenHocVien.Count; index++)
// // {
// //     if (danhSachTenHocVien[index] == "Khoi")
// //     {
// //         indexFind = index;
// //         break;
// //     }
// // }

// // System.Console.WriteLine($"indexFind : {indexFind}");

// // /*----------------------UPDATE (cập nhật giá trị của phần tử trong list)-------------------*/

// // danhSachTenHocVien[indexFind] = "Khoipro312";
// // System.Console.WriteLine($"{string.Join(",", danhSachTenHocVien)}");

// // /*---------------------------DELETE (xóa giá trị của phần tử trong list)-------------------*/
// // //xóa giá trị: Remove(gia_tri)
// // //xóa vị trí: RemoveAt(index)
// // danhSachTenHocVien.Remove("Hop");
// // System.Console.WriteLine($"{string.Join(",", danhSachTenHocVien)}");

// // danhSachTenHocVien.RemoveAt(0);
// // System.Console.WriteLine($"{string.Join(",", danhSachTenHocVien)}");

// // for (int index = danhSachTenHocVien.Count -1; index >= 0; index--)
// // {
// //     if (danhSachTenHocVien[index] == "Khoi")
// //     {
// //         danhSachTenHocVien.RemoveAt(index);
// //     }
// // }
// // System.Console.WriteLine($"sau khi xóa: {string.Join(",", danhSachTenHocVien)}");

// // /*---------------------------CREATE - INSERT: (thêm phần tử vào list)------------------*/

// // System.Console.WriteLine("Nhập vào 1 tên mới");
// // string newItem = Console.ReadLine();
// // //LST.Add(new_item)
// // danhSachTenHocVien.Add(newItem);
// // System.Console.WriteLine($"sau khi thêm {string.Join(",", danhSachTenHocVien)}");

// // //insert(index, newItem) chèn vào vị trí chỉ định
// // danhSachTenHocVien.Insert(0, newItem);
// // System.Console.WriteLine($"sau khi thêm {string.Join(",", danhSachTenHocVien)}");

// // //chèn nhiều phần tử:
// // List<string> lsten = new List<string>() { "Khôi", "Khôi312", "Khôipro"};
// // danhSachTenHocVien.AddRange(lsten);
// // System.Console.WriteLine($"sau khi thêm {string.Join(",", danhSachTenHocVien)}");

// // danhSachTenHocVien.InsertRange(1, lsten);
// // System.Console.WriteLine($"sau khi thêm {string.Join(",", danhSachTenHocVien)}");
// #endregion
// //----------------------------BỔ SUNG------------------------------------------
// /* TÌM KIẾM: STRING

//     string phoneName = "Iphone 14 pro max" -> keyword: 14 pro
//     phoneName.ToLower() : i phone 14 pro max
//     keyword.ToLower() : 14 pro
//     phoneName.indexOf("14 pro") => 7
//     contain.Contains("14 pro") => true

// */

// List<string> danhSachTenHocVien = new List<string>() {"Khoi pro 312", "Mam", "hehe", "haha", "hihi"};

// string keyword = "Khoi";

// //Tìm người có tên khôi đổi thành tên bình
// // for (int i = 0; i < danhSachTenHocVien.Count; i++)
// // {
// //     //mỗi lần duyệt lấy ra 1 tên theo index (0 -> count -1)
// //     string ten = danhSachTenHocVien[i];

// //     if (ten.Contains(keyword)) // nếu tên học viên chứa keyword thì if xử lý
// //     {
// //         danhSachTenHocVien[i] = "Binh";
// //     }
// // }
// System.Console.WriteLine($"sau khi thêm {string.Join(",", danhSachTenHocVien)}");

// //find: lấy ra item
// //findIndex: lấy ra vị trí của item

// string item = danhSachTenHocVien.Find(ten => ten.Contains(keyword));
// System.Console.WriteLine($"{item}");

// int ind = danhSachTenHocVien.FindIndex(ten => ten.Contains(keyword));
// System.Console.WriteLine($"vị trí tìm: {ind}");
// danhSachTenHocVien[ind] = "Binh";
// System.Console.WriteLine($"danh sách sau khi đổi tên: {string.Join(",", danhSachTenHocVien)}");


int ketQua = baiTap.baiTap1();

System.Console.WriteLine($"kết quả bài 1: {ketQua}");

int ketQua2 = baiTap.timSoLeNhoNhat();

System.Console.WriteLine($"Tim so le nho nhat {ketQua2}");
