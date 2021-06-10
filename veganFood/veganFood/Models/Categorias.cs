using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace veganFood.Models
{
    public class Categorias
    {
        public Categorias(){

            Receitas = new HashSet<Receitas>();
        
        }

        [Key]
        public int IdCategoria { get; set; }

        public string Designacao { get; set; }

        public string Fotografia { get; set; }

        public ICollection<Receitas> Receitas { get; set; }
    }
}
