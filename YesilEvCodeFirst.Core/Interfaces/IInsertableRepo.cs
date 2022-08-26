using System.Collections.Generic;

namespace YesilEvCodeFirst.Core.Interfaces
{
    public interface IInsertableRepo<T> : IRepo<T> where T : class
    {
        T Add(T item);
        List<T> AddRange(List<T> items);
    }
}
