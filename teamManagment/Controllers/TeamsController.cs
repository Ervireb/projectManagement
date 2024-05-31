using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace teamManagment.Controllers
{
    public class TeamsController : Controller
    {
        // GET: /Teams/
        public IActionResult Index()
        {
            // Возвращает список команд
            return View();
        }

        // GET: /Teams/Create
        public IActionResult Create()
        {
            // Возвращает форму для создания новой команды
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Team team)
        {
            // Создает новую команду
            // ...
            return RedirectToAction(nameof(Index));
        }

        // GET: /Teams/Edit/{id}
        public IActionResult Edit(int id)
        {
            // Возвращает форму для редактирования команды
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Models.Team team)
        {
            // Обновляет информацию о команде
            // ...
            return RedirectToAction(nameof(Index));
        }

        // GET: /Teams/Delete/{id}
        public IActionResult Delete(int id)
        {
            // Возвращает форму для удаления команды
            return View();
        }

        //[HttpPost]
        //public IActionResult Delete(int id)
        //{
        //    // Удаляет команду
        //    // ...
        //    return RedirectToAction(nameof(Index));
        //}
    }
}