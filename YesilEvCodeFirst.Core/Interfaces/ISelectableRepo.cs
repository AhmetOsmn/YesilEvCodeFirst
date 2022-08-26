using System;
using System.Collections.Generic;

namespace YesilEvCodeFirst.Core.Interfaces
{
    public interface ISelectableRepo<T> : IRepo<T> where T : class
    {
        List<T> GetAll();
        T GetByID(object ID);
        List<T> GetByCondition(Func<T, bool> whereCondition);
    }
}
