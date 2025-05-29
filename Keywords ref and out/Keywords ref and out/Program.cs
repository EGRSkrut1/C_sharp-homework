public class List_modifier
{
    public static bool Remove_first<T>(ref List<T> list, out T removed_item)
    {
        removed_item = default(T);
        if (list == null || list.Count == 0) return false;
        removed_item = list[0];
        list.RemoveAt(0);
        return true;
    }
    public static bool Remove_last<T>(ref List<T> list, out T removed_item)
    {
        removed_item = default(T);
        if (list == null || list.Count == 0) return false;
        removed_item = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return true;
    }
    public static bool Remove_at_index<T>(ref List<T> list, int index, out T removed_item)
    {
        removed_item = default(T);
        if (list == null || index < 0 || index >= list.Count) return false;
        removed_item = list[index];
        list.RemoveAt(index);
        return true;
    }
}

public class Program
{
    public static void Main()
    {
        List<string> names = new List<string> { "a", "b", "c", "d" };
        string removed;
        Console.WriteLine("Original list: " + string.Join(", ", names));
        if (List_modifier.Remove_first(ref names, out removed)) { Console.WriteLine("Removed first: " + removed); Console.WriteLine("List after removing first: " + string.Join(", ", names)); }
        else Console.WriteLine("Failed to remove the first element (empty list).");
        if (List_modifier.Remove_last(ref names, out removed)) { Console.WriteLine("Removed last: " + removed); Console.WriteLine("List after removing last: " + string.Join(", ", names)); }
        else Console.WriteLine("Failed to remove the last element (empty list).");
        if (List_modifier.Remove_at_index(ref names, 1, out removed)) { Console.WriteLine("Removed at index 1: " + removed); Console.WriteLine("List after removing at index 1: " + string.Join(", ", names)); }
        else Console.WriteLine("Failed to remove element at index (invalid index).");
    }
}