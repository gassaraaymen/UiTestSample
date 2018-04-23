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
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void Add_5_To_7_Returns_12_UITest()
        {
            // Arrange (Prepare Our Environment)
            app.Screenshot("Add text");
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

