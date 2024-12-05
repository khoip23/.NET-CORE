class method 
{
    #region hàm tính tổng
    /// <summary>
    /// ý nghĩa của hàm: đây là hàm dùng để tính tổng 2 số a và b
    /// </summary>
    /// <param name="a"> ý nghĩa tham số a</param>
    /// <param name="b">ý nghĩa tham số b</param>
    /// <returns> ý nghĩa của output</returns>
    // public static int tinhTong(int a, int b)
    // {
    //     int tong = a + b;

    //     return tong;
    // }

    #endregion

    #region hàm tìm số nguyên tố
    /// <summary>
    /// Hàm kiểm tra số nguyên tố
    /// </summary>
    /// <param name="so"> số n là số dương bất kỳ </param>
    /// <returns>kết quả trả về là true và ngược lại</returns>
    // public static bool kiemTraSoNguyenTo(int so = 7) //vd so 7 => true, so 4 => false
    // {
    //     bool flag = true; //output hàm

    //     for (int uoc = 2; uoc <= Math.Sqrt(so); uoc++)
    //     {
    //         if (so % uoc == 0)
    //         {
    //             flag = false;
    //             break;
    //         }
    //     }
    //     return flag;
    // }

    #endregion

    #region hàm in ra số sao n

    public static string inHangSao(int soSao) //soSao = 10 => **********
    {
        string output = "";

        for (int num =1; num <= soSao; num++)
        {
            output += $" * ";
        }

        output += "\n"; //sau khi in ra 1 hàng ngôi sao thì xuống dòng

        return output;

    }

    public static string inMaTranSao(int r, int c)
    {
        string output = "";

        for (int hang = 1; hang <= r; hang++)
        {
            //mỗi lần in ra 1 hàng (kết quả + 1 hàng)
            ketQua += method.inHangSao(c);
        }

        return output;
    }


    #endregion


}