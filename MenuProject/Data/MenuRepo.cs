using MenuProject.Models;
using System.Linq;

namespace MenuProject.Data
{
    public class MenuRepo : IMenuRepo
    {
        private readonly AppDbContext _context;

        public MenuRepo(AppDbContext context)
        {
           _context = context;
        }

        public void CreateMenu(Menu plat)
        {
            if(plat == null)
            {
                throw new ArgumentNullException(nameof(plat));
            }

            _context.Menus.Add(plat);
        }

        public IEnumerable<Menu> GetAllMenus()
        {
            return _context.Menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            return _context.Menus.FirstOrDefault(p => p.Id == id);
        }

        public Menu GetMenuByName(string name)
        {
            return _context.Menus.Where(p => p.Name == name).FirstOrDefault();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
