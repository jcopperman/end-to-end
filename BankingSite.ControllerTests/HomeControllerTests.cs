﻿using System.Runtime.InteropServices;
using BankingSite.Controllers;
using NUnit.Framework;
using TestStack.FluentMVCTesting;

namespace BankingSite.ControllerTests   
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void ShouldRedirectToLocalHostForContact()
        {
            var sut = new HomeController();

            sut.WithCallTo(x => x.Contact()).ShouldRedirectTo("http://localhost");
        }
    }
}
