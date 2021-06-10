using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace veganFood.Models
{
    public class Utilizadores
    {
        public Utilizadores()
        {
            Receitas = new HashSet<Receitas>();

        }
            [Key]
        public int IDutilizador { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// Chave estrangeira para a tabela de autenticação
        /// </summary>
        public string UserNameId { get; set; }

        public ICollection<Receitas> Receitas { get; set; }
    }
}
