using FoodAppAPI.Models;

namespace FoodAppAPI.Services.Interfaces
{
    public interface IMenuService
    {
        public Menu Create(Menu menu);
        public List<Menu> Get();
        public Menu Get(string id);
        public void Update(string id, Menu menu);
        public void Delete(string id);
    }
}
