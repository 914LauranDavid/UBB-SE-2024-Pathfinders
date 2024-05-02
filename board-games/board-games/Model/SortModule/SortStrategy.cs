namespace board_games.src.Sort
{
    public interface SortStrategy<T> where T : IComparable<T>
    {
        void Sort(List<T> data);
    }
}
