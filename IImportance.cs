namespace GenericDemo
{
    public interface IImportance<T>
    {
        T MostImportant(T a, T b);
    }
}
