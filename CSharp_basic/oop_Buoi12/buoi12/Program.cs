MenuQLNV menu = new MenuQLNV();
menu.HienThiChucNang();
while(true){
    Console.Write("Hãy chọn chức năng: ");
    menu.Chon = Convert.ToInt32(Console.ReadLine());
    switch(menu.Chon)
    {
        case 1:
        {
            menu.ThemNhanVien();
        }; break;

        case 6:
        {
            menu.LuuDSNV();
        }; break;
    }

    if (menu.Chon == 8)
    {
        break;
    }

    //nếu không thoát thì hiển thị lại menu
    menu.HienThiChucNang();
}