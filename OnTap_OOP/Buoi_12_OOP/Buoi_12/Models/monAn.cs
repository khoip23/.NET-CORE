public class monAn
{
    public static int CreatIDMonAn =1;
    public int maMonAn { get; set; }
    public string tenMonAn { get; set; }

    public double price { get; set; }

    public monAn()
    {
        //khi tạo đối tượng thì yêu cầu người dùng nhập vào món ăn
        nhapMonAn();
        //tăng id lên 1 đơn vị để các mã món ăn không trùng nhau
        maMonAn = CreatIDMonAn;
        monAn.CreatIDMonAn ++;
    }

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