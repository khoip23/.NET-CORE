public class monAn
{
    public int maMonAn { get; set; }
    public string? tenMonAn { get; set; }

    public double price { get; set; }

    public void nhapMonAn()
    {
        Console.Write("Nhập tên món: ");
        tenMonAn = Console.ReadLine();

        Console.Write("Nhập vào giá: ");
        price = Convert.ToDouble(Console.ReadLine());
    }

    public void xuatMonAn()
    {
        System.Console.Write($@"
            Mã món ăn: {maMonAn}
            Tên món ăn: {tenMonAn}
            Gía món ăn: {price}

        ");
    }
}