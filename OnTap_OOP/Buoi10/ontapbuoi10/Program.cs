object a = 5;
object b = 15;

int tong = (int)a + (int)b;

System.Console.WriteLine(tong);

dynamic c = 10;
decimal d = 15;

dynamic e = c / d;

System.Console.WriteLine($"e = {e}");

List<int> RS = new List<int>() {1,2,3,4,5};

Dictionary<string, string> dic = new Dictionary<string, string>() 
{ 
    { "id", "1"},
    { "name", "iphone"},
    { "price", "1000"},
};

object lst = (Dictionary<string,string>) dic;

System.Console.WriteLine($"Type: {lst.GetType()}");

//----------------------------------------------------------------------

System.Console.WriteLine("Nhập a:");
double so1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Nhập b:");
double so2 = Convert.ToDouble(Console.ReadLine());

object ketqua = Method.tinhChia(so1, so2);

if(ketqua.GetType() == typeof(double))
{
    System.Console.WriteLine($"Kết quả = {ketqua}");
}
else
{
    System.Console.WriteLine(ketqua);
}