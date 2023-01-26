using System.ComponentModel;

namespace Tarefas.Web.Models
{
    public class TarefaViewModel
    {

        [DisplayName("codigo")]
        public int Id {get;set;}

        [DisplayName("Titulo")]
        public string Titulo { get;set;}

        [DisplayName("Descricao")]
        public string Descricao {get;set;}
    }
}
