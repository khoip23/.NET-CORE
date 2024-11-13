public class ThanhToanOnline : IThanhToan
{
    public void ThanhToan(double soTien)
    {
        string maOTP;
        System.Console.Write("Nhập vào mã OTP của bạn: ");
        maOTP = Console.ReadLine();

        if (maOTP == "1234")
        {
            System.Console.WriteLine("Thanh toán thành công");
        }
        else
        {
            System.Console.WriteLine("Thanh toán thất bại");
        }
    }
}