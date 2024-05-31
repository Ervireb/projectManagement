using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace teamManagment.Controllers
{
    public class PersonnelController : Controller
    {
        // GET: /Personnel/
        public IActionResult Index()
        {
            // Возвращает список персонала
            return View();
        }

        // GET: /Personnel/Create
        public IActionResult Create()
        {
            // Возвращает форму для создания нового сотрудника
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Personnel personnel)
        {
            // Создает нового сотрудника
            // ...
            return RedirectToAction(nameof(Index));
        }

        // GET: /Personnel/Edit/{id}
        public IActionResult Edit(int id)
        {
            // Возвращает форму для редактирования сотрудника
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Models.Personnel personnel)
        {
            // Обновляет информацию о сотруднике
            // ...
            return RedirectToAction(nameof(Index));
        }

        // GET: /Personnel/Delete/{id}
        public IActionResult Delete(int id)
        {
            // Возвращает форму для удаления сотрудника
            return View();
        }

        //[HttpPost]
        //public IActionResult Delete(int id)
        //{
        //    // Удаляет сотрудника
        //    // ...
        //    return RedirectToAction(nameof(Index));
        //}
    }
}