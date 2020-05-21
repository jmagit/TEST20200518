using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demos.Fakes;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Microsoft.QualityTools.Testing.Fakes;
using System.IO;

namespace Demos.Tests {
    [TestClass]
    public class MSFakesTests {
        class LoadTextFileFake : ILoadTextFile {
            public string[] Lines { get; set; }
            public bool IsLoad { get; set; } = false;
            public int Size => 4;

            public LoadTextFileFake(string file) {
                Lines = new string[] { "cero", "uno", "dos", "cuatro" };
                IsLoad = true;
            }
        }

        [TestMethod]
        public void DemoStubTest() {
            // var obj = new LoadTextFile(@"D:\Cursos\dotnet\MSTEST20200518\Demos.Tests\AreaTest.csv");
            var obj = new LoadTextFileFake(@"D:\Cursos\dotnet\MSTEST20200518\Demos.Tests\AreaTest.csv");
            //ILoadTextFile obj = new StubILoadTextFile() {
            //    SizeGet = () => 3
            //};

            IProcessTextFile calc = new StubIProcessTextFile() {
                CalculateILoadTextFile = (ILoadTextFile arg) => arg.Size == 4 ? "OK" : "KO"
            };
            var rslt = calc.Calculate(obj);

            IsNotNull(obj);
            //AreEqual(4, obj.Size);
            AreEqual("OK", rslt);

        }

        [TestMethod]
        public void DemoShimTest() {
            var obj = new LoadTextFile(@"D:\Cursos\dotnet\MSTEST20200518\Demos.Tests\AreaTest.csv");
            IProcessTextFile calc = new StubIProcessTextFile() {
                CalculateILoadTextFile = (ILoadTextFile arg) => arg.Size == 3 ? "OK" : "KO"
            };

            using (Microsoft.QualityTools.Testing.Fakes.ShimsContext.Create()) {
                System.IO.Fakes.ShimFile.ReadAllLinesString =
                    s => new string[] { "cero", "uno", "dos" };
                var arrage = new LoadTextFile(@"D:\Cursos\dotnet\MSTEST20200518\Demos.Tests\AreaTest.csv");
                Assert.IsTrue(arrage.IsLoad);
                Assert.AreEqual(3, arrage.Size);
                Assert.AreEqual("dos", arrage.Lines[2]);
                Assert.AreEqual("uno", arrage.Lines[1]);
                Assert.AreEqual("cero", arrage.Lines[0]);
                var rslt = calc.Calculate(arrage);

                IsNotNull(arrage);
                //AreEqual(4, arrage.Size);
                AreEqual("OK", rslt);
            }
        }
        [TestMethod]
        public void DemoSpyTest() {
            using (ShimsContext.Create()) {
                int cont = 0;
                const string filename = @"D:\Cursos\dotnet\MSTEST20200518\Demos.Tests\AreaTest.csv";
                System.IO.Fakes.ShimFile.ReadAllLinesString = s => {
                    Assert.AreEqual(filename, s);
                    cont++;
                    string[] rslt = null;
                    ShimsContext.ExecuteWithoutShims(() => { rslt = File.ReadAllLines(s); });
                    return rslt;
                };
                var arrage = new LoadTextFile(filename);
                Assert.AreEqual(1, cont);
                AreEqual(4, arrage.Size);
            }
        }

    }
}
