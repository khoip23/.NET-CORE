System.Console.WriteLine("Chào mừng đến với hệ thống thanh toán!");
System.Console.WriteLine("1. Thanh toán bằng tiền mặt");
System.Console.WriteLine("2. Thanh toán bằng thẻ");
System.Console.WriteLine("3. Thanh toán Online");
System.Console.WriteLine("4. Xem lịch sử giao dịch");
System.Console.WriteLine("5. Thoát");

static List<GiaoDich> lichSuGiaoDich()
{

    var list = new List<GiaoDich>(); // handle chua co file
    if (System.IO.File.Exists("./lichsu.json"))
    {
        string jsonCu = System.IO.File.ReadAllText("./lichsu.json");
        list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GiaoDich>>(jsonCu); //new List<GiaoDich>();
    }


    return list;
}

static void lsgd()
{
    Console.WriteLine("Lịch sử giao dịch của bạn: ");

    List<GiaoDich> list = lichSuGiaoDich();

    foreach (GiaoDich i in list)
    {
        System.Console.WriteLine(i.SoTien);
    }
}

while (true)
{
    IThanhToan? t = null;
    System.Console.Write("Nhập vào lựa chọn thanh toán của bạn: ");

    int luaChon = Convert.ToInt32(Console.ReadLine());

    if (luaChon == 5)
    {
        break;
    }

    switch (luaChon)
    {

        case 1:
            {
                t = new ThanhToanTienMat();

                break;
            }

        case 2:
            {
                t = new ThanhToanBangThe();

                break;
            }

        case 3:
            {
                t = new ThanhToanOnline();

                break;
            }

        case 4:
            {
                lsgd();
                break;
            }

        default:
            {
                System.Console.WriteLine("Lựa chọn của bạn không đúng, vui lòng nhập lại lựa chọn!");
            }
            break;

    }
    if (t != null)
    {
        Console.Write("Nhập vào số tiền cần thanh toán");
        double soTienCanThanhToan = Convert.ToDouble(Console.ReadLine());
        t.ThanhToan(soTienCanThanhToan);
        var gd = new GiaoDich()
        {
            SoTien = soTienCanThanhToan,
            ThoiGian = DateTime.Now,
        };
        var list = lichSuGiaoDich();
        list.Add(gd);
        string noiDungFileJson = Newtonsoft.Json.JsonConvert.SerializeObject(list); // dung thu vien de serialize
        // var xxx = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GiaoDich>>(x);

        //ghi đè file
        System.IO.File.WriteAllText("./lichsu.json", noiDungFileJson);
    }


}

// luu tren memory (RAM)
// luu tren disk (SSD, o cung)

public class GiaoDich
{
    public double SoTien { get; set; }
    public DateTime ThoiGian { get; set; }
}

