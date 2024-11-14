class ThucPham : SanPham
{
    private double PhiVanChuyen;

    public ThucPham(string ma, string ten, double giaGoc, double phiVanChuyen) 
        : base(ma, ten, giaGoc)
    {
        PhiVanChuyen = phiVanChuyen;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc + PhiVanChuyen;
    }
}