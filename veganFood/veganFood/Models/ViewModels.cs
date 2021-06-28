using System;


namespace veganFood.Models
{

    /// <summary>
    /// ViewModel para transportar os dados das Receitas para a API
    /// </summary>
    public class ReceitasAPIViewModel
    {
        /// <summary>
        /// Id da Receita
        /// </summary>
        public int IDreceita { get; set; }

        /// <summary>
        /// Descrição da Receita
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Ingredientes da Receita
        /// </summary>
        public string Ingredientes { get; set; }

        /// <summary>
        /// Modo de Preparo da Receita
        /// </summary>
        public string ModoPreparo { get; set; }
    }

    /// <summary>
    /// ViewModel para transformar do dados das Fotografias para a API
    /// </summary>
    public class FotografiasAPIViewModel
    {
        /// <summary>
        /// Id da fotografia
        /// </summary>
        public int IDfotografia { get; set; }

        /// <summary>
        /// Fotografia
        /// </summary>
        public string Fotografia { get; set; }
    }


    public class ViewModels {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        }
}


