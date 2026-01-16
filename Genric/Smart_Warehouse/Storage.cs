using System.Collections.Generic;
namespace Genric;

public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayAllItems()
    {
        foreach (T item in items)
        {
            item.Display();
        }
    }
}
