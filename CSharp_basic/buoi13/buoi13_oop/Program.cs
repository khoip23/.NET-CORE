using System.Text.Json;
GiangVien gv = new GiangVien("emailGV", "passGV");
gv.Email = "gv@gmail.com";
gv.MatKhau = "123@123";
gv.HoTen = "Nga";
gv.SoDienThoai = "0909090909";
gv.CacLopGiangDay = new List<string>(){"NET01", "NET02", "NET03"};

gv.DangNhap();

System.Console.WriteLine($"{JsonSerializer.Serialize(gv)}");

