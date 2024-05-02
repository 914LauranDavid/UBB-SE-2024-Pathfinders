namespace board_games.src.Sort
{
    public class MergeSortStrategy<T> : SortStrategy<T> where T : IComparable<T>
    {
        private int _sortingMultiplier = 1;
        public MergeSortStrategy() { }
        public MergeSortStrategy(bool isAscending)
        {
            if (!isAscending)
            {
                _sortingMultiplier = -1;
            }
        }
        private void DivideEtImpera(List<T> data, int leftIndex, int rightIndex)
        {
            if(leftIndex >= rightIndex) return;
            int middleIndex = (leftIndex + rightIndex) / 2;
            DivideEtImpera(data, leftIndex, middleIndex);
            DivideEtImpera(data, middleIndex + 1, rightIndex);

            Merge(data, leftIndex, middleIndex, rightIndex);
        }
        private void Merge(List<T> data, int leftIndex, int middleIndex, int rightIndex)
        {
            int i = leftIndex, j = middleIndex + 1;
            List<T> temporaryList = new List<T>();
            while(i <= middleIndex && j <= rightIndex)
            {
                if (data[i].CompareTo(data[j]) * _sortingMultiplier < 0){
                    temporaryList.Add(data[i]);
                    i++;
                }
                else { temporaryList.Add(data[j]); j++; }
            }
            while (i <= middleIndex)
            {
                temporaryList.Add(data[i]);
                i++;
            }
            while(j<=rightIndex) { temporaryList.Add(data[j]); j++; }

            for(int index = leftIndex; index <=rightIndex; index++)
            {
                data[index] = temporaryList[index - leftIndex];
            }
        }
        public void Sort(List<T> data)
        {
            DivideEtImpera(data, 0, data.Count-1);
        }
    }
}
