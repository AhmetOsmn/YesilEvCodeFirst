using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface ISupplierDAL :
        IDeletableRepo<Supplier>,
        IInsertableRepo<Supplier>,
        IUpdatableRepo<Supplier>,
        ISelectableRepo<Supplier>
    {
    }
}
