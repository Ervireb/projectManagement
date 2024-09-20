using Microsoft.VisualStudio.TestTools.UnitTesting;
using mvp_app.Models;
using mvp_app.Presenters;
using mvp_app.Views;
using Moq;

namespace mvp_app.Tests
{
    [TestClass]
    public class PresenterTests
    {
        private Mock<IView> mockView;
        private Model model;
        private Presenter presenter;

        [TestInitialize]
        public void Setup()
        {
            mockView = new Mock<IView>();
            model = new Model();
            presenter = new Presenter(mockView.Object);
        }

        [TestMethod]
        public void TestLoadData()
        {
            // Arrange
            string expectedData = "Hello, MVP!";
            //presenter.LoadData(); // Загружаем данные в модель

            // Act
            //presenter.LoadData(); // Метод, который вы должны реализовать в презентере для загрузки данных

            // Assert
            mockView.Verify(v => v.DisplayData(expectedData), Times.Exactly(1));
        }

        private readonly IView _view; // Поле для хранения ссылки на представление
        private readonly Model _model; // Поле для хранения ссылки на модель


        public void LoadData()
        {
            _model.LoadData(); // Загружаем данные из модели
            _view.DisplayData(_model.Data); // Отображаем данные через представление
        }
    }
}