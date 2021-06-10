using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace veganFood.Models
{
    public class Receitas
    {
        public Receitas()
        {
            Fotografias = new HashSet<Fotografias>();
            Categorias = new HashSet<Categorias>();

        }

        [Key]
        public int IDreceita { get; set; }

        public string Descricao { get; set; }

        public string Ingredientes { get; set; }

        public string ModoPreparo { get; set; }


        [ForeignKey("Autor")]
        public int AutorFK { get; set; }
        public Utilizadores Autor { get; set; }


        public ICollection<Fotografias> Fotografias { get; set; }

        public ICollection<Categorias> Categorias { get; set; }
    }

}

