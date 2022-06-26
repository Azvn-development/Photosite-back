using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Photosite.BLL.DTO.Services;
using Photosite.DAL.Entities;
using System.Threading.Tasks;

namespace Photosite.Test.Tests.Services
{
    public class GetServicesHandlerTest : BaseTest
    {
        private IMediator _mediator;

        protected override void SetupInternal()
        {
            _mediator = _serivceProvider.GetService<IMediator>();

            _dbContext.AddRange(new[]
            {
                new ServiceEntity
                {
                    Id = 0,
                    Name = "Service",
                },
                new ServiceEntity
                {
                    Id = 0,
                    Name = "Service",
                }
            });

            _dbContext.SaveChanges();
        }

        [Test]
        [TestCaseSource(nameof(GetServicesTestSource))]
        public async Task GetServicesTest(GetServicesQuery query)
        {
            // Act
            var result = await _mediator.Send(query);

            // Assert
            Assert.That(result.Services.Count, Is.EqualTo(2));
        } // GetServicesTest

        // Source
        private static readonly object[] GetServicesTestSource = new[]
        {
            new object[]
            {
                new GetServicesQuery()
            }
        };
    }
}
