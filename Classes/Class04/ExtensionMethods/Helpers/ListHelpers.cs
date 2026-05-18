namespace ExtensionMethods.Helpers
{
    public static class ListHelpers
    {
        public static void PrintItems<T>(this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintListInfo<T>(this List<T> items)
        {
            string listType = typeof(T).Name;
            Console.WriteLine($"This list has {items.Count} elements and is of type {listType}");
        }
    }
}
