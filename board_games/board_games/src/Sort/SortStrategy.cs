using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace board_games.src.Sort
{
    public interface SortStrategy<T> where T : IComparable<T>
    {
        void Sort(List<T> data);
    }
}
