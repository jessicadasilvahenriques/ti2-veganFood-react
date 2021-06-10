using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace veganFood.Models
{
    public class Fotografias
    {
        [Key]
        public int IDfotografia { get; set; }
        public string Fotografia { get; set; }



        [ForeignKey(nameof(Receita))]
        public int ReceitaFK { get; set; }
        public Receitas Receita { get; set; }

   

    }
}
