using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IProductDAL : 
        IInsertableRepo<Product>,
        IUpdatableRepo<Product>,
        ISelectableRepo<Product>,
        IDeletableRepo<Product>
        // hangi interface'ler eklenecek?
    {
    }
}
