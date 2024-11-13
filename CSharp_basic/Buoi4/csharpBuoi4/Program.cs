#region In ra hình chữ nhật ngôi sao

System.Console.WriteLine("Nhập vào sso dòng: ");
int row = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Nhập vào sso cột: ");
int colum = int.Parse(System.Console.ReadLine());

for (int i = 1; i <= row; i++)
{
    for (int j = 1; j <= colum; j++)
    {
        System.Console.Write("*");
    }
    Console.WriteLine();
}
#endregion

