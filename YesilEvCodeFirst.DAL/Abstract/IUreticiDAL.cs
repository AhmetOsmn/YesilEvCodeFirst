using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IUreticiDAL :
        IDeletableRepo<Uretici>,
        IInsertableRepo<Uretici>,
        IUpdatableRepo<Uretici>,
        ISelectableRepo<Uretici>
    {
    }
}
