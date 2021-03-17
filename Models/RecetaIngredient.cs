using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recetas.Models
{
    public class RecetaIngredient
    {
        public int Id { get; set; }
        public Receta Receta { get; set; }
        public int RecetaId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }
        public double Cantidad { get; set; }
    }
}
