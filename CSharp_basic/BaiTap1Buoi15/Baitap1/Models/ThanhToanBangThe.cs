public class ThanhToanBangThe : IThanhToan
{
    public void ThanhToan(double soTien)
    {
        string maPin;
        System.Console.Write("Nhập vào mã pin của bạn: ");
        maPin = Console.ReadLine();

        if (maPin == "9999")
        {
            System.Console.WriteLine("Thanh toán thành công");
        }
        else
        {
            System.Console.WriteLine("Thanh toán thất bại");
        }
    }
}