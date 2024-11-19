menuQLVN menu = new MenuQLVN;
menu.HienThiChucNang();
menu.ChonChucNang();

while (menu.ChonChucNang != 6)
{
    switch (menu.ChonChucNang)
    {
        case 1: // thêm nhân viên
        {
            menu.ThemNhanVien();
        }
        break;
        case 5:
        {
            menu.HienThiDanhSach();
        }
        break;
        default:
        {

        }
        break;
    }
    menu.HienThiChucNang();
    menu.ChonChucNang();
}34