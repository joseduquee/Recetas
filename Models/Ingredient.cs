﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recetas.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Receta Receta { get; set; }
        public List<Receta> Recetas { get; set; }
    }
}
