internal class Program
{
    private static void Main(string[] args)
    {
        object a = "abc";
        object b = "def";

        dynamic c = 10;
        dynamic d = 20;



        dynamic e = d / c;
        System.Console.WriteLine(e);

        string tong = (string)a + (string)b;

        System.Console.WriteLine(tong);

        List<int> res = new List<int>(){1,2,3,4,5,6,7};

        Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            {"id", "1"},
            {"name", "phone"},
            {"price", "1000"},
        };

        object lst = (Dictionary<string, string>) dic;

        //xem type của biến
        System.Console.WriteLine($"type: {lst.GetType()}"); 


        /*--------------------------------------------------------------*/
        System.Console.Write("Nhập a:");
        double a1 = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Nhập b:");
        double b1 = Convert.ToDouble(Console.ReadLine());

        object ketqua = Method.tinhChia(a1, b1);

        if(ketqua.GetType() == typeof(double))
        {
            System.Console.WriteLine($"ketqua = {ketqua}");
        }
        else
        {
            System.Console.WriteLine(ketqua);
        }

    }
}