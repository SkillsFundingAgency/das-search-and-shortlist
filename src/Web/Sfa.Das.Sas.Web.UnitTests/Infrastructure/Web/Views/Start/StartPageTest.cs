﻿using FluentAssertions;
using NUnit.Framework;
using RazorGenerator.Testing;
using Sfa.Das.Sas.Web.UnitTests.Infrastructure.Web.ExtensionHelpers;

namespace Sfa.Das.Sas.Web.UnitTests.Infrastructure.Web.Views.Start
{
    [TestFixture]
    public class StartPageTest : ViewTestBase
    {
        [Test]
        public void ShouldHaveStartButton()
        {
            var startPage = new Sas.Web.Views.Start.Start();

            var html = startPage.RenderAsHtml().ToAngleSharp();

            var button = GetHtmlElement(html, "#start-button");

            button.OuterHtml.Should().Contain(" id=\"start-button\"");
        }
    }
}
