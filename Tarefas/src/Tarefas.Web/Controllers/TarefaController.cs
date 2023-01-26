using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers
{      
    public class TarefaController : Controller
    {
        public List<TarefaViewModel> listaDeTarefas{get;set; }
        public TarefaController()
        {
            listaDeTarefas = new List<TarefaViewModel>()
            {
                 new TarefaViewModel(){ Titulo = "Indo para academia", Descricao = "Segunda a sabado"},
                 new TarefaViewModel(){ Titulo = "Fazendo almoco", Descricao = "All days"}
                    
             };
        }

        public IActionResult Create()
        {
            return View();
        }

        public  IActionResult Index()
        {
             
                    return View(listaDeTarefas);
         }
        public IActionResult Details(int id)
        {
            var tarefa = listaDeTarefas.Find(tarefa => tarefa.Id == id);
            return View(tarefa);
        }
    }   
}

