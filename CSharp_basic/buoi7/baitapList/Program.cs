using b8_lst_on_tap.baiTap1;

internal class Program
{
 
    private static void Main(string[] args)
    {
        System.Console.WriteLine($"BT1: tong cac so lun hon 20: {baiTapBuoi8.baiTap1()}");

        System.Console.WriteLine($"BT2: co {baiTapBuoi8.baiTap2()} so lon hon 20");
        
        System.Console.WriteLine($"BT3: So lon nhat trong lisst la: {baiTapBuoi8.timSoLN()}");

        List<int> lstNumber = new List<int>(){2, 7, 11, 15};

        int target = 26;

        List<int> lsItem = baiTapBuoi8.baiTapPlus(lstNumber, target);
        System.Console.WriteLine($"BTPLUS: vị trí 2 số có tổng bằng {target} là {string.Join(",",lsItem)} ");

        List<int> lstTrungLap1 = baiTapBuoi8.removeIndex();
        System.Console.WriteLine($"BTREMOVE: list sau xóa trùng lặp: {string.Join(",",lstTrungLap1)}");
    }
}