using AngleSharp.Dom;
using Bunit;
using FakeItEasy;
using System;
using WebApp.Pages;
using Xunit;

namespace WebAppTest
{
    public class IndexTest : TestContext
    {
        private readonly IRenderedComponent<WebApp.Pages.Index> _component;
        private readonly IElement _input;
        private readonly IElement _button;
        private readonly IElement _output;

        public IndexTest()
        {
            _component = RenderComponent<WebApp.Pages.Index>();
            _input = _component.Find("input");
            _button = _component.Find("button");
            _output = _component.Find("td");

            VerifyInitialState();
        }

        private void VerifyInitialState()
        {
            _input.MarkupMatches("<input placeholder=\"xxxx-xxxx-xxxx\" class=\"traceinput\" value =\"\" />");
            _button.MarkupMatches("<button>Enter</button>");
            _output.MarkupMatches("<td>@status.Message</td>");
        }

        [Theory,
        InlineData("123456789123", "Order Recieved")]
        private void Should_returnStatusHistory_When_givenPackageNumber(string first, string expectedResult)
        {
            // Arrange
            _input.Change(first);

            // Act
            _button.Click();

            string result = _output.TextContent;
            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Theory,
        InlineData("123456789123", "No Order Found")]
        private void Should_returnInvalid_WhengivenWrongPackageNumber(string first, string expectedResult)
        {
            // Arrange
            _input.Change(first);

            // Act
            _button.Click();

            string result = _output.TextContent;

            // Assert 
            Assert.Equal(expectedResult, result);
        }

        [Theory,
        InlineData("Fisk", "Invalid Package Number")]
        private void Should_returnInvalid_WhengivenInvalidInput(string first, string expectedResult)
        {
            // Arrange
            _input.Change(first);

            // Act
            _button.Click();

            string result = _output.TextContent;

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}