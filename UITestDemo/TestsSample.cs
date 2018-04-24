using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class TestsSample
    {
        IApp app;
        Platform platform;

        public TestsSample(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = UITestDemo.AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("Home Page");
        }

        [Test]
        public void Introduction()
        {
            AppLaunches();
            app.Tap("ImageUi");
            app.Screenshot("Introduction");
        }

        [Test]
        public void DatePicker()
        {
            AppLaunches();
            app.Tap(x => x.Marked("Gallery"));
            app.Screenshot("Gallery");
            app.Tap(x => x.Marked("ButtonElement"));
            app.Screenshot("Element");
            app.Tap(x => x.Marked("DatePickerA"));
            app.Screenshot("DatePicker");
            app.Tap(x => x.Id("date_picker_header_year"));
            app.Screenshot("YearView");
            app.Tap(x => x.Text("2019"));
            app.Tap(x => x.Id("next"));
            app.Screenshot("MonthView");
            app.Tap(x => x.Id("button1"));
        }

        [Test]
        public void CarsGallery()
        {
            AppLaunches();
            app.Tap(x => x.Marked("Gallery"));
            app.Screenshot("Gallery");
            app.Tap(x => x.Marked("ButtonGallery"));
            app.Screenshot("CarsGallery");
            app.SwipeLeftToRight();
            app.Screenshot("Car1");
            app.SwipeRightToLeft();
            app.Screenshot("Car2");
        }

        [Test]
        public void OpenREPL()
        {
            app.Repl();
        }

        [Test]
        public void Picker()
        {
            AppLaunches();
            app.Tap(x => x.Marked("Gallery"));
            app.Tap(x => x.Marked("ButtonElement"));
            app.Tap(x => x.Marked("PickerC"));
            app.Screenshot("Picker");
            app.Tap(x => x.Text("Mauritania"));
            app.Screenshot("Mauritania Selected");
        }

        [Test]
        public void ListView()
        {
            AppLaunches();
            app.Tap(x => x.Marked("Gallery"));
            app.Tap(x => x.Marked("ButtonElement"));
            app.Screenshot("ListView");
            app.Tap(x => x.Class("TextCellRenderer_TextCellView"));
            app.Screenshot("Aymen Selected");
            app.Tap(x => x.Id("button2"));
            app.Tap(x => x.Text("Emna"));
            app.Screenshot("Emna Selected");
            app.Tap(x => x.Id("button2"));
            app.Tap(x => x.Text("Mounir"));
            app.Screenshot("Mounir Selected");
            app.Tap(x => x.Id("button2"));
            app.Tap(x => x.Text("Fawzi"));
            app.Screenshot("Fawzi Selected");
            app.Tap(x => x.Id("button2"));
        }

        [Test]
        public void Switcher()
        {
            AppLaunches();
            app.Tap("Switch");
            app.Screenshot("Switch On");
            app.Tap("SwitchA");
            app.Screenshot("Switch Off");
            app.Tap("SwitchA");
            app.Screenshot("Switch On");
        }

        [Test]
        public void RadioButton()
        {
            AppLaunches();
            app.Tap(x => x.Marked("Gallery"));
            app.Tap("ButtonRadio");
            app.Screenshot("ButtonRadio");
            app.Tap("ImageNoSort");
            app.Screenshot("ImageNoSort Selected");
            app.Tap("ImageAtoZ");
            app.Screenshot("ImageAtoZ Selected");
            app.Tap("ImageZtoA");
            app.Screenshot("ImageZtoA Selected");
        }

        [Test]
        public void Slider()
        {
            AppLaunches();
            app.Tap("Switch");
            app.Screenshot("Slider");
            app.SetSliderValue("SliderA", 200);
            app.Screenshot("SliderChanged");
        }

        [Test]
        public void Add_5_To_7_Returns_12_UITest()
        {


            // Arrange (Prepare Our Environment)
            AppLaunches();
            app.Tap("Calculator");
            app.Screenshot("Fill The Blank");
            app.EnterText("EntryA", "5");
            app.EnterText("EntryB", "7");
            app.Screenshot("value setted up");
            // Act

            app.Tap("ButtonAdd");
            app.Screenshot("Result");

            //Assert

            var appResult = app.Query("LabelResult").First(result => result.Text == "12");
            Assert.IsTrue(appResult != null, "Label is not displaying the right result !");
        }


        [Test]
        public void Multiply_5_To_7_Returns_35_UITest()
        {
            // Arrange (Prepare Our Environment)
            AppLaunches();
            app.Tap("Calculator");
            app.Screenshot("Fill The Blank");
            app.EnterText("EntryA", "5");
            app.EnterText("EntryB", "7");
            app.Screenshot("value setted up");
            // Act

            app.Tap("ButtonMultiply");
            app.Screenshot("Result");
            //Assert

            var appResult = app.Query("LabelResult").First(result => result.Text == "35");
            Assert.IsTrue(appResult != null, "Label is not displaying the right result !");
        }
    }
}

