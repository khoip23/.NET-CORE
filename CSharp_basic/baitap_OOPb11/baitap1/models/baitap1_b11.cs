public class Task
{
    public static int CreateID = 0;
    public int ID { get; set; }
    public string? TaskName { get; set; }
    public bool Completed { get; set;} = false; // true: đã hoàn thành : flase chưa hoàn thành (mặc định false khi thêm mới task thì chưa làm)

    public Task() // Hàm khởi tạp mặc định
    {
        ID = CreateID;
        CreateID++;
    }

    public void inputTask()
    {
        System.Console.WriteLine("Input task name: ");
        TaskName = Console.ReadLine();
    }

    public void displayInfoTask()
    {
        System.Console.WriteLine($"Task name: {TaskName} -Conpleted: {Completed} ");
    }

    public void updateTask(bool status)
    {
        Completed = status;
    }
}