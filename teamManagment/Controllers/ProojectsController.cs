using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace teamManagment.Controllers
{
    public class ProojectsController : Controller
    {
        // GET: /Proojects/
        public IActionResult Index()
        {
            // Возвращает список проектов
            return View();
        }

        // GET: /Proojects/Create
        public IActionResult Create()
        {
            // Возвращает форму для создания нового проекта
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Prooject Prooject)
        {
            // Создает новый проект
            // ...
            return RedirectToAction(nameof(Index));
        }

        // GET: /Proojects/Edit/{id}
        public IActionResult Edit(int id)
        {
            // Возвращает форму для редактирования проекта
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Models.Prooject Prooject)
        {
            // Обновляет информацию о проекте
            // ...
            return RedirectToAction(nameof(Index));
        }

        // GET: /Proojects/Delete/{id}
        public IActionResult Delete(int id)
        {
            // Возвращает форму для удаления проекта
            return View();
        }

        //[HttpPost]
        //public IActionResult Delete(int id)
        //{
        //    // Удаляет проект
        //    // ...
        //    return RedirectToAction(nameof(Index));
        //}
    }
}