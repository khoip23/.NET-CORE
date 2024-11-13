class baiTap
{
    static List<int> lstNumber = new List<int>() {20, 30, 31,26, 45, 34, 33, 36, 74, 86, 32};
    //Tính tổng các phần tử trong list
    public static baiTap1()
    {
        //input: lstNumer (đề cho)

        //output: tong: int
        int tong = 0;
        //process
        foreach (int number in lstNumber)
        {
            tong += number;
        }

        return tong;
    }

    public static timSoNhoNhat()
    {
        //input: lstNumer (đề cho)

        //output: so nho nhat slNN: int;

        //process

        int soNN = lstNumber[0];

        foreach(int number in lstNumber)
        {               
            if (number % 2 == 0 && number < soNN)
            {
                soNN = number;
            }
        }

        return 0;
    } 
}