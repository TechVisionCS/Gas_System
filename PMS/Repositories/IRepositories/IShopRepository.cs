using PMS.Models;

namespace PMS.Repositories.IRepositories
{
    public interface IShopRepository
    {
        Shop GetShop();
        Shop AddShop(Shop shop);
        Shop UpdateShop(Shop shop);
    }
}
