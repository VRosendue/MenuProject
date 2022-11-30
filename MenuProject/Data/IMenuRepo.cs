using MenuProject.Models;

namespace MenuProject.Data
{
    public interface IMenuRepo
    {
        bool SaveChanges();

        IEnumerable<Menu> GetAllMenus();

        Menu GetMenuByName(string name);

        Menu GetMenuById(int id);
        void CreateMenu(Menu plat);


    }
}
