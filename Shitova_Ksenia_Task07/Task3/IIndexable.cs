
namespace Task3
{
    public interface IIndexable
    {
        int GetLength();
        double this[int index] { get; }
    }
}
