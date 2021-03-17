using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recetas.Models
{
    public class Receta
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Foto { get; set; }
        public int MenuCategoryId { get; set; }
        public int UserId { get; set; }
        public int CuisineTypeId { get; set; }
        public MenuCategory MenuCategory { get; set; }
        public User User { get; set; }
        public List<RecetaIngredient> RecetaIngredients { get; set; }
        public RecetaIngredient RecetaIngredient { get; set; }
        public Ingredient Ingredientl { get; set; }




    }
}
