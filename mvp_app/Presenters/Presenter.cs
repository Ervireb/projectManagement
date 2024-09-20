using mvp_app.Models;
using mvp_app.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_app.Presenters
{
    public class Presenter
    {
        private readonly IView _view;
        private readonly Model _model;

        public Presenter(IView view)
        {
            _view = view;
            _model = new Model();
            LoadData(); // Загружаем данные при создании презентера
        }

        public void LoadData()
        {
            _model.LoadData(); // Загружаем данные из модели
            _view.DisplayData(_model.Data); // Отображаем данные через представление
        }
    }
}
