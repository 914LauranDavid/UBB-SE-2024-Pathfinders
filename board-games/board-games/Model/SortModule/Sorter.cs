namespace board_games.src.Sort
{
    public class Sorter<T> where T : IComparable<T>
    {
        private SortStrategy<T>? _strategy = null;
        public Sorter() { }
        public void SetStrategy(SortStrategy<T> strategy)
        {
            _strategy = strategy;
        }
        public void Sort(List<T> data) {
            if(_strategy != null)
            {
                _strategy.Sort(data);
            }
            else
            {
                throw new Exception("Strategy not selected");
            }
        }
    }
}
