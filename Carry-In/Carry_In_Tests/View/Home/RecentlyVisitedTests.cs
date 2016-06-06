using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Carry_In_Tests.View.Home
{
    [TestClass]
    public class RecentlyVisitedTests
    {
        public Carry_In.View.Home.RecentlyVisitedPage RecentlyVisitedPage { get; set; }
        [TestInitialize]
        public void Initialize()
        {
            RecentlyVisitedPage = new Carry_In.View.Home.RecentlyVisitedPage(); // { BindingContext = null };
        }

        [TestMethod]
        public void Instantiating_Class()
        {
            
        }
    }
}
