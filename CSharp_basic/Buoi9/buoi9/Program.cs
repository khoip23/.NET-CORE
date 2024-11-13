internal class Program
{
    private static void Main(string[] args)
    {
        #region lý thuyết dict
        // //dict (dictionary)

        // Dictionary<string, string> dPerson  = new Dictionary<string, string>();

        // dPerson["id"] = "001"; 

        // dPerson["name"] = "Khôi Phạm";

        // foreach (string Values in dPerson.Values)
        // {
        //     System.Console.WriteLine(Values);
        // }

        // foreach (string key in dPerson.Keys)
        // {
        //     System.Console.WriteLine(key);

        //     System.Console.WriteLine(dPerson[key]);
        // }

        // //xóa phần tử trong dict: dict.Remove(key)
        // dPerson.Remove("id"); //=> key id

        // foreach (string key in dPerson.Keys)
        // {
        //     System.Console.WriteLine($"Key {key} : value {dPerson[key]}");
        // }

        // //xóa hết: dict.Clear();
        // // dPerson.Clear();

        // // foreach (string key in dPerson.Keys)
        // // {
        // //     System.Console.WriteLine($"Key {key} : value {dPerson[key]}");
        // // }

        // System.Console.WriteLine($"Count : {dPerson.Values.Count}");

        // //tìm key có tồn tại trong dict không
        // bool valid = dPerson.ContainsKey("id");

        // System.Console.WriteLine($"name: {valid}");

        // //chuyển từ dict sang list

        // List<string> lstValue = dPerson.Values.ToList();

        // System.Console.WriteLine($"{string.Join(", ", lstValue)}");

        #endregion

        #region  baitap tosum
        // Dictionary<int, int> dictKetQua = baiTap.toSum(17);

        // foreach (int key in dictKetQua.Keys)
        // {
        //     System.Console.WriteLine($"Key {key} : value {dictKetQua[key]}");
        // }
        #endregion
    
        #region  lý thuyết HashSet

        // List <int> lstNumber = new List <int> () {1,2,3,4,5,6,4,2,6,8};

        // HashSet<int> setNumber = new HashSet<int> (lstNumber);

        // foreach (int i in setNumber)
        // {
        //     System.Console.WriteLine(i);
        // }

        #endregion
    
        #region LÝ THUYẾT ARRAY & ARRAY LIST

        string[] arrName = new string[3] {"Nam", "Minh", "Hằng"};

        #endregion 
    
    }
}