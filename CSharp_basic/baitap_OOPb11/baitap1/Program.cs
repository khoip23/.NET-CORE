using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine(@"
            -----TO DO APP-----
            1 - Thêm Task
            2 - Hiển thị task
            3 - Completed task
            4 - Thoát
        ");

        List<Task> lstTask = new List<Task>(); 
        /* 
        [
        {ID: 1, TaskName: "Task1", Completed: false}, 0
        {ID: 2, TaskName: "Task2", Completed: false}, 1
        {ID: 3, TaskName: "Task3", Completed: false}, 2
        ]
        */
        System.Console.Write("Nhập vào lựa chọn của bạn: ");

        string? luaChon = Console.ReadLine();

        while (luaChon != "4")
        {
            switch (luaChon)
            {
                case "1":
                {
                    System.Console.WriteLine("Chức năng 1:");

                    //tạo ra 1 task mới
                    Task newTask = new Task();
                    //cho người dùng nhập liệu
                    newTask.inputTask();

                    //xử lý chức năng 1
                    lstTask.Add(newTask); // lstTask = [{task1}, {task2},{tast3}]

                    break;
                }

                case "2":
                {
                    System.Console.WriteLine("Chức năng 2:");
                    foreach (Task task in lstTask)
                    {
                        task.displayInfoTask();
                    }
                    
                    break;
                }

                case "3":
                {
                    System.Console.Write("nhập và id task đã hoàn thành");
                    int idChon = Convert.ToInt32(Console.ReadLine());
                    // dựa vào id để tìm ra task update
                    Task? testKetQua = lstTask.Find(taskItem => taskItem.ID == idChon);

                    testKetQua.updateTask(true);
                    
                    break;
                }

                case "4":
                {
                    luaChon = "4";
                    break;
                }

                default:
                {
                    System.Console.WriteLine("Nhập vào lựa chọn đúng!!!");

                    break;
                }
            }
            System.Console.WriteLine(@"
            -----TO DO APP-----
            1 - Thêm Task
            2 - Hiển thị 
            3 - Completed task
            4 - Thoát
        ");
        
        System.Console.Write("Nhập lựa chọn:");
        luaChon = Console.ReadLine();

        }

        System.Console.WriteLine("Ứng dụng đã đợc đóng!");
    }
}