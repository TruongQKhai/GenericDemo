namespace GenericDemo
{
    public class BetterList<T>
    {
        private List<T> data = new();

        public void AddToList(T value)
        {
            data.Add(value);
            Console.WriteLine($"{value} has been add to the list");
        }
    }
}
