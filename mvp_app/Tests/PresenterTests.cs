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

        private readonly IView _view; // Поле для хранения ссылки на представление
        private readonly Model _model; // Поле для хранения ссылки на модель


        public void LoadData()
        {
            _model.LoadData(); // Загружаем данные из модели
            _view.DisplayData(_model.Data, 14f); // Отображаем данные через представление
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
            mockView.Verify(v => v.DisplayData(expectedData, It.IsAny<float>()), Times.Exactly(1));
        }



        [TestMethod]
        public void Presenter_should_select_null_item()
        {
            // Arrange
            mockView.SetupSet(x => x.SelectedItemId = 0).Verifiable();
            mockView.SetupSet(x => x.SelectedItemTitle = "").Verifiable();

            // Act
            presenter.SelectItem(null);

            // Assert
            mockView.VerifyAll();
        }


        [TestMethod]
        public void Presenter_should_select_item()
        {
            // Arrange
            var model = new Model { Id = 1, Title = "Abc" };
            mockView.SetupSet(x => x.SelectedItemId = model.Id).Verifiable();
            mockView.SetupSet(x => x.SelectedItemTitle = model.Title).Verifiable();

            // Act
            presenter.SelectItem(model);

            // Assert
            mockView.VerifyAll();
        }

        [TestMethod]
        public void Empty_button_check()
        {
            // Arrange
            var form = new Form1();
            form.ButtonLoad.Text = "";

            // Act
            var buttonText = form.ButtonLoad.Text; // Получаем текст кнопки

            // Assert
            Assert.AreEqual(string.Empty, buttonText); // Проверяем, что текст кнопки равен пустой строке
        }

    }
}