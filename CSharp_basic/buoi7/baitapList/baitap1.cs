namespace b8_lst_on_tap.baiTap1;

class baiTapBuoi8()
{
    static List<int> lstNumber = new List<int>() {20, 30, 31,26, 45, 34, 33, 36, 74, 86, 32};

    public static int baiTap1()
    {
        int tong = 0;

        for (int i = 0; i < lstNumber.Count; i++)
        {
            int numItem = lstNumber[i];
            if (numItem > 20)
            {
                tong += numItem;
            }
        }

        return tong;
    }

    public static int baiTap2()
    {
        int dem = 0;

        foreach(int num in lstNumber)
        {
            if (num > 20)
            {
                dem++;
            }
        }

        return dem;
    }

    public static int timSoLN()
    {
        int max = lstNumber[0];

        foreach(int num in lstNumber)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }

    public static List<int> baiTapPlus(List<int> lstNumber, int target)
    {
        List<int> lstNum = new List<int>();
        for(int i = 0; i < lstNumber.Count; i++)
        {
            //mỗi lần duyệt qua index
            //sẽ duyệt 1 vòng lặp từ index + 1
            
            for (int j = i + 1; j < lstNumber.Count; j++)
            {
                if (lstNumber[i] + lstNumber[j] == target)
                {
                    lstNum.Add(i);
                    lstNum.Add(j);
                    return lstNum; //lệnh return sẽ dừng hàm
                }
            }
        }

        return lstNum;
    }

    public static List<int> removeIndex()
    {
        List<int> List = new List<int>() {1, 1, 2, 2, 3, 3, 4, 4, 5};

        List<int> lstTrungLap = new List<int>();

        foreach (int num in List)
        {
            if (!lstTrungLap.Contains(num))
            lstTrungLap.Add(num);
            return lstTrungLap;
        }
        return lstTrungLap;
    }
}