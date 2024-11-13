//HocVien là class dẫn xuất (class con -derived class) : kế thừa các thuộc tính và phương thức của class cha (public, protected...)
class HocVien : NguoiDung 
{ //C# chỉ hỗ trợ kế thừa từ 1 class
    public void DocTaiLieu()
    {
        System.Console.WriteLine("Đọc tài liệu");
    }

    public void NopBai()
    {
        System.Console.WriteLine("Nộp bài thành công");
    }
}