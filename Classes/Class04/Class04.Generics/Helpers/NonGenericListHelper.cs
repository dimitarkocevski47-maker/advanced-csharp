namespace Class04.Generics.Helpers
{
    public class NonGenericListHelper
    {
        public void PrintStrings(List<string> strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintInfoForStrings(List<string> strings)
        {
            string first = strings[0];
            string elementType = first.GetType().Name;

            Console.WriteLine($"This list has {strings.Count} elements and is of type {elementType}");
        }

        public void PrintIntegers(List<int> integers)
        {
            foreach (var item in integers)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintInfoForIntegers(List<int> integers)
        {
            int first = integers[0];
            string elementType = first.GetType().Name;

            Console.WriteLine($"This list has {integers.Count} elements and is of type {elementType}");
        }

        public void PrintBooleans(List<bool> booleans)
        {
            foreach (var item in booleans)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintInfoForBools(List<bool> bools)
        {
            bool first = bools[0];
            string elementType = first.GetType().Name;

            Console.WriteLine($"This list has {bools.Count} elements and is of type {elementType}");
        }
    }
}
