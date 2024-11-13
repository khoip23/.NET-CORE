using System.Collections;
using System.Reflection;
class CRUD<T>
{
    public List<T> lstItem = new List<T>();

    public int selected = 0;

    public void AddItem(T NewItem)
    {
        lstItem.Add(NewItem);
    }

    public T findItem(int id)
    {
        T? item = lstItem.Find(p => 
        {
            dynamic it = (dynamic)p;
            return it.id == id;
        } );
        return item;
    }

    public void showAllItem()
    {
        Type type = typeof(T);
        PropertyInfo[] lstProperty = type.GetProperties();
        foreach (object item in lstItem)
        {
            foreach (PropertyInfo prop in lstProperty)
            {
                System.Console.WriteLine($"{prop.Name} - {prop.GetValue(item)}");
            }
        }
    }
}