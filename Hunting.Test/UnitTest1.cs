using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hunting.Serialization;

namespace Hunting.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var model = new DataModel();
            model.Events = new List<Event> { new Event() { Name = "Birthday", Date = new DateTime(1980, 10, 12) } };
            model.Projects = new List<Project> { new Project() { Name = "Preparation BIC" } };
            model.Tasks = new List<Task> { new Task() { Login = "Yura" }, new Task() { Login = "Andre" } };
            DataSerializer.SerializeData(@"C:\My files\Hunting.dat", model);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var model = DataSerializer.DeserializeItem(@"C:\My files\Hunting.dat");
        }
    }
}
