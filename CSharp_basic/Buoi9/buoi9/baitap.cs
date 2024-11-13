class baiTap
{
    public static List<int> lstNumber = new List<int>(){2, 7, 11, 15};
    public static Dictionary<int, int> toSum(int target)
    {
        Dictionary<int, int> number = new Dictionary<int, int>();

        for (int i = 0; i < lstNumber.Count; i ++)
        {
            int complement = target - lstNumber[i];

            if(number.ContainsKey(complement))
            {
                //tìm thấy
                return new Dictionary<int, int>
                {
                    {i, number[complement]}
                };
            }

            number.Add(lstNumber[i], i); //=> {2 : 0, 7 : 1, 11 : 2, 15 : 3}
        }

        return number;
    }
}