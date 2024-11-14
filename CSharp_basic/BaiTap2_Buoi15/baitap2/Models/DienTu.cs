class DienTu : SanPham
{
    private double ThueBaoHanh;

    public DienTu(string ma, string ten, double giaGoc, double thueBaoHanh) 
        : base(ma, ten, giaGoc)
    {
        ThueBaoHanh = thueBaoHanh;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc + ThueBaoHanh;
    }
}