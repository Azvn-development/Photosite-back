using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Photosite.BLL.DTO.Services;
using Photosite.DAL.Entities;
using System.Threading.Tasks;

namespace Photosite.Test.Tests.Services
{
    public class UpdateServiceHandlerTest : BaseTest
    {
        private IMediator _mediator;

        protected override void SetupInternal()
        {
            _mediator = _serivceProvider.GetService<IMediator>();

            var service = new ServiceEntity
            {
                Id = 1,
                Name = "Service",
            };

            _dbContext.Add(service);
            _dbContext.SaveChanges();

            _dbContext.Entry(service).State = EntityState.Detached;
        }

        [Test]
        [TestCaseSource(nameof(UpdateServiceTestSource))]
        public async Task UpdateServiceTest(UpdateServiceCommand command)
        {
            // Act
            var result = await _mediator.Send(command);

            // Assert
            Assert.That(result.Id, Is.EqualTo(command.Service.Id));
        } // UpdateServiceTest

        // Source
        private static readonly object[] UpdateServiceTestSource = new[]
        {
            new object[]
            {
                new UpdateServiceCommand
                {
                    Service = new()
                    {
                        Id = 1,
                        Name = "Service",
                    }
                }
            }
        };
    }
}
