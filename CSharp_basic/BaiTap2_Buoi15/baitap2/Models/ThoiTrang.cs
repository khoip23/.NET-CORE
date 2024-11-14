class ThoiTrang : SanPham
{
    private double GiamGiaTheoMua;

    public ThoiTrang(string ma, string ten, double giaGoc, double giamGia) 
        : base(ma, ten, giaGoc)
    {
        GiamGiaTheoMua = giamGia;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc - GiamGiaTheoMua;
    }
}