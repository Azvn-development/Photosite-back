using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Photosite.BLL.DTO.Abouts;
using System.Threading.Tasks;

namespace Photosite.Test.Tests.Abouts
{
    public class CreateAboutHandlerTest : BaseTest
    {
        private IMediator _mediator;

        protected override void SetupInternal()
        {
            _mediator = _serivceProvider.GetService<IMediator>();
        }

        [Test]
        [TestCaseSource(nameof(CreateAboutTestSource))]
        public async Task CreateAboutTest(CreateAboutCommand command)
        {
            // Act
            var result = await _mediator.Send(command);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        } // CreateAboutTest

        // Source
        private static readonly object[] CreateAboutTestSource = new[]
        {
            new object[]
            {
                new CreateAboutCommand
                {
                    About = new()
                    {
                        Id = 0,
                        Text = "Text",
                        Title = "Title",
                        Image = "12345"
                    }
                }
            }
        };
    }
}
