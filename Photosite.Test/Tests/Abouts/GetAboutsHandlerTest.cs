using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Photosite.BLL.DTO.Abouts;
using Photosite.DAL.Entities;
using System.Threading.Tasks;

namespace Photosite.Test.Tests.Abouts
{
    public class GetAboutsHandlerTest : BaseTest
    {
        private IMediator _mediator;

        protected override void SetupInternal()
        {
            _mediator = _serivceProvider.GetService<IMediator>();

            _dbContext.AddRange(new[]
            {
                new AboutEntity
                {
                    Id = 0,
                    Text = "Text",
                    Title = "Title",
                    Image = "12345"
                },
                new AboutEntity
                {
                    Id = 0,
                    Text = "Text",
                    Title = "Title",
                    Image = "12345"
                }
            });

            _dbContext.SaveChanges();
        }

        [Test]
        [TestCaseSource(nameof(GetAboutsTestSource))]
        public async Task GetAboutsTest(GetAboutsQuery query)
        {
            // Act
            var result = await _mediator.Send(query);

            // Assert
            Assert.That(result.Abouts.Count, Is.EqualTo(2));
        } // GetAboutsTest

        // Source
        private static readonly object[] GetAboutsTestSource = new[]
        {
            new object[]
            {
                new GetAboutsQuery()
            }
        };
    }
}
