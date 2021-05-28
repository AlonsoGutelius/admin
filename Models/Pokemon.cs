using System.Collections.Generic;

namespace app.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Tipo> Tipos{ get; set; }
    }
}
