using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface ICategoryDAL :
        ISelectableRepo<Category>,
        IDeletableRepo<Category>,
        IUpdatableRepo<Category>,
        IInsertableRepo<Category>
        //todo: hangi interface'lerin eklenecegine nasıl karar verecegiz?
    {
    }
}
