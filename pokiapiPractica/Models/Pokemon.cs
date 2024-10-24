using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pokiapiPractica.Models
{
    // Models/Pokemon.cs
    public class Pokemon
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Ability> Abilities { get; set; } = new List<Ability>(); // Inicializa la lista aquí
    }

    public class Ability
    {
        public AbilityDetails AbilityData { get; set; } // Esto es correcto
    }

    public class AbilityDetails
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

}