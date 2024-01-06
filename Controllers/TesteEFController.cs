using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Data;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class TesteEFController : Controller
    {
        public AppDbContext Db { get;set; }
        public TesteEFController(AppDbContext db)
        {
            Db = db;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Ativo = true,
                Avaliacao = 9,
                DataNascimento = new DateTime(1973, 12, 11),
                Email="teste@gmail.com",
                Nome="Paulo L. V. Teixeira"
            };


            Db.Alunos.Add(aluno);
            Db.SaveChanges();

            return View();
        }
    }
}
