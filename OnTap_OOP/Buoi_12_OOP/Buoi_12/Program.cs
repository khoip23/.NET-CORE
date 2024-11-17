Menu menuMonAn = new Menu(); 
menuMonAn.HienThiChucNang();
menuMonAn.ChonChucNang();

while (menuMonAn.Chon != 4)
{
    switch (menuMonAn.Chon)
    {
        case 1: //tạo ra món ăn
        {
            monAn monan = new monAn();
            menuMonAn.themMonAn(monan);
        }
        break;
        case 2:
        {
            menuMonAn.HienThiMenu();
        }
        break;
        case 3:
        {
            menuMonAn.XoaMonAn();
        }
        break;
        case 4:
        {
            menuMonAn.Thoat();
        }
        break;
        default:
        {
            System.Console.WriteLine("Lựa chọn sai!");
        }
        break;
    }
    
    menuMonAn.HienThiChucNang();
    menuMonAn.ChonChucNang();
}