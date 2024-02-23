namespace GenericDemo
{
    /// <summary>
    /// public class SampleClass<T> where T : new() -> type 'T' must be a parameterless Constructor
    /// public class SampleClass<T> where T : class? new() -> type 'T' must be a class and a parameterless Constructor
    /// public class SampleClass<T> where T : notnull 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SampleClass<T, U> where T : class, new()
    {

    }
}
