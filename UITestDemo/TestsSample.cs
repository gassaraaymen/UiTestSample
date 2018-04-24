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
        public void SwipeRight()
        {
            app.SwipeRightToLeft();
        }

        [Test]
        public void SwipeLeft()
        {
            app.SwipeLeftToRight();
        }

        [Test]
        public void Introduction()
        {
            app.Screenshot("Home Page");
            app.Tap("ImageUi");
            app.Screenshot("Introduction");
        }


        [Test]
        public void DatePicker()
        {
            app.Tap(x => x.Marked("Gallery"));
            app.Tap(x => x.Marked("ButtonElement"));
            app.Tap(x => x.Marked("DatePickerA"));
            app.Tap(x => x.Id("date_picker_header_year"));
            app.Tap(x => x.Text("2019"));
            app.Tap(x => x.Id("next"));
            app.Tap(x => x.Id("button1"));
        }

        [Test]
        public void CarsGallery()
        {
            app.Tap(x => x.Marked("Gallery"));
            app.Tap(x => x.Marked("ButtonGallery"));            
            app.SwipeLeftToRight();
            app.SwipeRightToLeft();                
        }

        [Test]
        public void OpenREPL()
        {
            app.Repl();
        }


        [Test]
        public void Picker()
        {
            app.Tap(x => x.Marked("Gallery"));
            app.Tap(x => x.Marked("ButtonElement"));
            app.Tap(x => x.Marked("PickerC"));
            app.Tap(x => x.Text("Mauritania"));
        }

        [Test]
        public void ListView()
        {
            app.Tap(x => x.Marked("Gallery"));
            app.Tap(x => x.Marked("ButtonElement"));
            app.Tap(x => x.Class("TextCellRenderer_TextCellView"));
            app.Tap(x => x.Id("button2"));
            app.Tap(x => x.Text("Emna"));
            app.Tap(x => x.Id("button2"));
            app.Tap(x => x.Text("Mounir"));
            app.Tap(x => x.Id("button2"));
            app.Tap(x => x.Text("Fawzi"));
            app.Tap(x => x.Id("button2"));
        }

        [Test]
        public void Switcher()
        {
            app.Tap("Switch");
            app.Screenshot("Switch On");
            app.Tap("SwitchA");
            app.Screenshot("Switch Off");
            app.Tap("SwitchA");
            app.Screenshot("Switch On");
        }

        [Test]
        public void SelectPicker()
        {
            app.Tap("Gallery");
            app.Tap("PickerC");            
            app.Tap("Morocco");
        }

        [Test]
        public void Slider()
        {
            app.Tap("Switch");
            app.SetSliderValue("SliderA", 10);
            app.SetSliderValue("SliderA", 50);
            app.SetSliderValue("SliderA", 100);
            app.SetSliderValue("SliderA", 150);
            app.SetSliderValue("SliderA", 300);
        }

        [Test]
        public void Add_5_To_7_Returns_12_UITest()
        {


            // Arrange (Prepare Our Environment)
            app.Screenshot("Add text");
            app.Tap("Calculator");
            app.EnterText("EntryA", "5");
            app.EnterText("EntryB", "7");

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
            app.Screenshot("Add text");
            app.Tap("Calculator");
            app.EnterText("EntryA", "5");
            app.EnterText("EntryB", "7");

            // Act

            app.Tap("ButtonMultiply");
            app.Screenshot("Result");
            //Assert

            var appResult = app.Query("LabelResult").First(result => result.Text == "35");
            Assert.IsTrue(appResult != null, "Label is not displaying the right result !");
        }
    }
}

