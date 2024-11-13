internal class Program
{
    private static void Main(string[] args)
    {

        //Cú pháp khai báo list
        List<string> danhSachHV = new List<string>() {"Khải", "Minh", "Nga", "Minh", "Nam", "Minh"};


        System.Console.WriteLine(string.Join(",", danhSachHV));

        /*--------------------------READ-------------------------*/
        //lấy ra 1 phần tử tên_list[index]
        System.Console.WriteLine(danhSachHV[2]);
        System.Console.WriteLine(danhSachHV.ElementAt(3));
        System.Console.WriteLine(danhSachHV[^4]);

        foreach (string tenHV in danhSachHV)
        {
            System.Console.WriteLine($"Tên học viên: {tenHV}");
        }

        //.Sort(): hàm có sẵn của list hỗ trợ sắp xếp phần tử
        danhSachHV.Sort();
        System.Console.WriteLine($"{string.Join(",", danhSachHV)}");

        //.Reverse(): hàm đảo ngược list
        danhSachHV.Reverse();
        System.Console.WriteLine($"{string.Join(",", danhSachHV)}");

        List<int> giaTien = new List<int>() { 500, 1000, 2050, 300, 100};

        giaTien.Sort();
        System.Console.WriteLine($"{string.Join(",", giaTien)}");

        giaTien.Reverse();
        System.Console.WriteLine($"{string.Join(",", giaTien)}");

        /*---------------------------------------------------*/
        //TÌM KIẾM PHẦN TỬ TRONG LIST: KỸ THUẬT ĐẶT CỜ
        int indexFind = -1; //truy vết cờ hiệu
        
        for (int i = 0; i < danhSachHV.Count; i++)
        {
            if (danhSachHV[i] == "Nam")
            {
                indexFind = i;
                break;
            }
        }

        System.Console.WriteLine($"indexFind = {indexFind}");
        
        /*-------------------------UPDATE--------------------------*/
        //cập nhật giá trị phần tử trong list

        danhSachHV[indexFind] = "Khôi";
        System.Console.WriteLine($"{string.Join(",", danhSachHV)}");

        /*-------------------------DELETE--------------------------*/
        //XÓA GIÁ TRỊ TRONG LIST
        //-xóa giá trị: Remove(giá trị)
        //- xóa theo vị trí: RemoveAt(index)
        danhSachHV.Remove("Minh");
        danhSachHV.RemoveAt(1);
        System.Console.WriteLine($"{string.Join(",", danhSachHV)}");

        List<string> danhSachHV1 = new List<string>() {"Khải", "Minh", "Nga", "Minh", "Nam", "Minh"};

        for (int i = danhSachHV1.Count - 1; i >= 0; i--)
        {
            if  (danhSachHV1[i] == "Minh")
            {
                danhSachHV1.RemoveAt(i);
            }
        } 
          
        System.Console.WriteLine($"sau khi xóa: {string.Join(",", danhSachHV1)}");

        /*-------------------------CREAT--------------------------*/
        //THÊM PHẦN TỬ VÀO LIST
        System.Console.WriteLine("Nhập vào 1 tên mới:");
        string newItem = Console.ReadLine();

        //lst.Add(new_Item)
        danhSachHV.Add(newItem);

        System.Console.WriteLine($"{string.Join(",", danhSachHV)}");

        //insert: chèn vào vị trí chỉ định
        //insert(index, newItem)

        danhSachHV.Insert(2, newItem);
        System.Console.WriteLine($"{string.Join(",", danhSachHV)}");

        //CHÈN NHIỀU PHẦN TỬ:
        List<string> lstTen = new List<string>() {"khoi", "hanh pro 312",};

        danhSachHV.AddRange(lstTen);
        System.Console.WriteLine($" sau khi thêm 1 list{string.Join(",", danhSachHV)}");

        /*----------------BỔ SUNG----------------------*/

        

        
    }
}
