class baitapBuoi8()
{
    public static int[] twoSum(int[] lstNumber2, int target)
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        for (int i = 0; i < lstNumber2.Length; i++)
        {
            int complement = target - lstNumber2[i];

            if (numDict.ContainsKey(complement))
            {
                return new int[] {numDict[complement], i };
            }

            numDict[lstNumber2[i]] = i;
        }
        return Array.Empty<int>();
    }
}