using System.Collections.Generic;

namespace app.Models
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

          public ICollection<Pokemon> Pokemones{ get; set; }
    }
}