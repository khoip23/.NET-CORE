internal class Program
{
    static int dong;
    static int cot;
    private static void Main(string[] args)
    {
        #region BAI TAP TINH TONG
        // System.Console.WriteLine("a = ");
        // int soA = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("b = ");
        // int soB = int.Parse(Console.ReadLine());

        // int ketQua = method.tinhTong(soA, soB);
        // System.Console.WriteLine(ketQua);

        #endregion

        #region  Bài tập tìm số nguyên tố
        //bài tập viết chương trình in ra số nguyên tố từ 2 tới n
        // input int n;
        // System.Console.Write("Nhập vào n: ");
        // int n = int.Parse(Console.ReadLine());
        // //output  string ketQua = "2 3 5 7...."
        // string ketQua = "";

        // for (int num = 2; num <= n; num ++)
        // {
        //     //mỗi làn duyệt qua 1 số num thì đêm số đó đi kểm tra => true or false
        //     bool kt = method.kiemTraSoNguyenTo(num);
        //     if (kt)
        //     {
        //         ketQua += $" {num}";
        //     }
        // }

        // //in output ra màn hình
        // System.Console.WriteLine($"Dãy số nguyên tố: {ketQua}");
        #endregion

        #region  bài tập in ra ma trận sao

        // string hangSao = method.inHangSao(20);

        // System.Console.WriteLine(hangSao);

        //viết chương trình nhập vào dòng và cột in ra ma trận sao tương ứng

        // input dong: int; cot: int;
        nhapDongCot();
        // System.Console.WriteLine("Nhập và số dòng: ");
        // int dong = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("Nhập và số cột: ");
        // int cot = int.Parse(Console.ReadLine());

        // //output: ketQua: string;
        string ketQua = "";

        // //process
        // for (int hang = 1; hang <= dong; hang++)
        // {
        //     //mỗi lần in ra 1 hàng (kết quả + 1 hàng)
        //     ketQua += method.inHangSao(cot);
        // }

        ketQua = method.inMaTranSao(dong, cot);

        //in ra output ra màn hình
        System.Console.WriteLine(ketQua);
        #endregion

    }

    static void nhapDongCot()
    {
        System.Console.WriteLine("Nhập và số dòng: ");
        dong = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Nhập và số cột: ");
        cot = int.Parse(Console.ReadLine());
    }

}