namespace Scopy.Abstract
{
    public interface IValueScope<T> where T : new()
    {
        T Value { get; init; }
    }
}
