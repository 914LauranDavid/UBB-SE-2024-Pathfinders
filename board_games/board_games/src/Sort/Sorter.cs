using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.src.Sort
{
    public class Sorter<T> where T : IComparable<T>
    {
        private SortStrategy<T>? strategy = null;
        public Sorter() { }
        public void SetStrategy(SortStrategy<T> strategy)
        {
            this.strategy = strategy;
        }
        public void Sort(List<T> data) {
            if(strategy != null)
            {
                strategy.Sort(data);
            }
            else
            {
                throw new Exception("Strategy not selected");
            }
        }
    }
}
