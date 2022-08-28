using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface ISupplementDAL :
        IInsertableRepo<Supplement>,
        ISelectableRepo<Supplement>,
        IDeletableRepo<Supplement>,
        IUpdatableRepo<Supplement>
    {
    }
}
