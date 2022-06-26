using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Photosite.BLL.DTO.Abouts;
using Photosite.DAL.Entities;
using System.Threading.Tasks;

namespace Photosite.Test.Tests.Abouts
{
    public class DeleteAboutHandlerTest : BaseTest
    {
        private IMediator _mediator;

        protected override void SetupInternal()
        {
            _mediator = _serivceProvider.GetService<IMediator>();

            var about = new AboutEntity
            {
                Id = 1,
                Text = "Text",
                Title = "Title",
                Image = "1234",
            };

            _dbContext.Add(about);
            _dbContext.SaveChanges();

            _dbContext.Entry(about).State = EntityState.Detached;
        }

        [Test]
        [TestCaseSource(nameof(DeleteAboutTestSource))]
        public async Task DeleteAboutTest(DeleteAboutCommand command)
        {
            // Act
            var result = await _mediator.Send(command);

            // Assert
            Assert.That(result, Is.EqualTo(command.Id));
        } // DeleteAboutTest

        // Source
        private static readonly object[] DeleteAboutTestSource = new[]
        {
            new object[]
            {
                new DeleteAboutCommand
                {
                    Id = 1
                }
            }
        };
    }
}
