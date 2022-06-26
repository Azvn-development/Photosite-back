using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Photosite.BLL.DTO.Services;
using System.Threading.Tasks;

namespace Photosite.Test.Tests.Services
{
    public class CreateServiceHandlerTest : BaseTest
    {
        private IMediator _mediator;

        protected override void SetupInternal()
        {
            _mediator = _serivceProvider.GetService<IMediator>();
        }

        [Test]
        [TestCaseSource(nameof(CreateServiceTestSource))]
        public async Task CreateServiceTest(CreateServiceCommand command)
        {
            // Act
            var result = await _mediator.Send(command);

            // Assert
            Assert.That(result.Id, Is.EqualTo(1));
        } // CreateServiceTest

        // Source
        private static readonly object[] CreateServiceTestSource = new[]
        {
            new object[]
            {
                new CreateServiceCommand
                {
                    Service = new()
                    {
                        Id = 0,
                        Name = "Service",
                    }
                }
            }
        };
    }
}
