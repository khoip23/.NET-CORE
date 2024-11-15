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
            menuMonAn.themMonAn(monAn);
        }
        break;

        case 2:
        {

        }
        break;

        case 3:
        {
            
        }
        break;
    }
    

    menuMonAn.HienThiChucNang();
    menuMonAn.ChonChucNang();
}