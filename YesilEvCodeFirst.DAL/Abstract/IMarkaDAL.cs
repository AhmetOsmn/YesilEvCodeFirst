using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IMarkaDAL :
        ISelectableRepo<Marka>,
        IUpdatableRepo<Marka>,
        IDeletableRepo<Marka>,
        IInsertableRepo<Marka>
    {
    }
}
