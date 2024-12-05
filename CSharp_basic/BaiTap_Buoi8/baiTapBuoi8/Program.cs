internal class Program
{

    #region Hàm Xóa phần tử bài 3
    // static int xoaPhanTuTrungLap(int[] nums)
    // {
    //     if (nums.Length == 0)
    //         return 0;

    //     int uniqueIndex = 0;

    //     for (int i = 1; i < nums.Length; i++)
    //     {
            
    //         if (nums[i] != nums[uniqueIndex])
    //         {
    //             uniqueIndex++;
    //             nums[uniqueIndex] = nums[i];
    //         }
    //     }

    //     return uniqueIndex + 1;
    // }

    #endregion
    
    #region Hàm tìm kiếm

    //  static List<int> FindTopKFrequent(int[] nums, int k)
    // {
    //     Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

    //     foreach (var num in nums)
    //     {
    //         if (frequencyDict.ContainsKey(num))
    //         {
    //             frequencyDict[num]++;
    //         }
    //         else
    //         {
    //             frequencyDict[num] = 1;
    //         }
    //     }

    //     var topK = frequencyDict.OrderByDescending(x => x.Value)
    //                             .Take(k)
    //                             .Select(x => x.Key)
    //                             .ToList();

    //     return topK;
    // }
    #endregion
    #region Hàm tính cổ phiếu
    //  static int MaxProfit(int[] prices)
    // {
    //     if (prices.Length == 0) return 0;

    //     int minPrice = prices[0]; // Giá cổ phiếu thấp nhất hiện tại
    //     int maxProfit = 0; // Lợi nhuận tối đa

    //     for (int i = 1; i < prices.Length; i++)
    //     {
    //         // Cập nhật giá cổ phiếu thấp nhất
    //         if (prices[i] < minPrice)
    //         {
    //             minPrice = prices[i];
    //         }
    //         // Tính toán lợi nhuận nếu bán cổ phiếu ở giá hiện tại
    //         else
    //         {
    //             maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
    //         }
    //     }

    //     return maxProfit;
    // }

    #endregion
    private static void Main(string[] args)
    {
        #region Bài tập 1: tính tổng các phần tử trong mảng
        // int[] lstNumber = {20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20};

        // int tong = 0;

        // foreach (int i in lstNumber)
        // {
        //     tong += i;
        // }

        // System.Console.WriteLine($"Tổng các phần tử trong mảng = {tong}");

        #endregion
    
        #region Bài tập 2: ToSum

        // int[] lstNumber2 = {2, 7, 11, 15};

        // // System.Console.WriteLine("Nhập vào target: "); //target do người dùng nhập vào
        // // int target = int.Parse(Console.ReadLine());

        // int target = 9;

        // int[] ketQua = baitapBuoi8.twoSum(lstNumber2, target);

        // if (ketQua.Length > 0)
        // {
        //     System.Console.WriteLine($"Output: {ketQua[0]}, {ketQua[1]}");
        // }  
        // else
        // {
        //     System.Console.WriteLine("Không tìm thấy cặp số nào");
        // }
        #endregion   
    
        #region  Bài tập 3: loại bỏ phần tử trùng lặp tử 1 mảng đã xắp sếp và trả về chiều dài của mảng mới

        // int[] nums = { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
        
        // int chieuDaiNew = xoaPhanTuTrungLap(nums);
        
        // Console.WriteLine($"Output: {chieuDaiNew}");
        // Console.Write("Mảng mới: [");
        // for (int i = 0; i < chieuDaiNew; i++)
        // {
        //     Console.Write(nums[i]);
        //     if (i < chieuDaiNew - 1) Console.Write(", ");
        // }
        // Console.WriteLine("]");
        #endregion
    
        #region Bài Tập 4: tìm phần tử xuất hiện nhiều nhất (bài này tham khảo GPT huhu)

        // int[] nums = { 1, 1, 1, 2, 2, 3 };
        // int k = 2;

        // List<int> result = FindTopKFrequent(nums, k);

        // Console.WriteLine($"Output: số xuất hiện nhiều là [{string.Join(", ", result)}]");
        #endregion
    
        #region Bài tập 5: cổ phiếu (bài này cũng tham khảo GPT huhuhu)
        // int[] prices = { 7, 1, 5, 3, 6, 4 };

        // int result = MaxProfit(prices);

        // Console.WriteLine($"Output: {result}");

        #endregion
    }
}
