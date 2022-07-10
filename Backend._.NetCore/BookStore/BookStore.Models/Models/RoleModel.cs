using BookStore.Models.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Models
{
    public class RoleModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public RoleModel() { }
        public RoleModel(Role role)
        {
            Id = role.Id;
            Name = role.Name;
        }
    }
}