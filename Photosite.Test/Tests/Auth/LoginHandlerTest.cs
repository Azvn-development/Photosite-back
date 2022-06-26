using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Photosite.BLL.DTO.Auth;
using Photosite.BLL.Models;
using Photosite.DAL.Entities;
using System.Threading.Tasks;

namespace Photosite.Test.Tests.Auth
{
    public class LoginHandlerTest : BaseTest
    {
        private IMediator _mediator;

        protected override void SetupInternal()
        {
            _mediator = _serivceProvider.GetRequiredService<IMediator>();

            _dbContext.Add(new UserEntity
            {
                Id = 0,
                Login = "Admin",
                Password = "12345"
            });

            _dbContext.SaveChanges();
        }

        [Test]
        [TestCaseSource(nameof(LoginTestSource))]
        public async Task LoginTest(LoginCommand command)
        {
            // Act
            var result = await _mediator.Send(command);

            // Assert
            Assert.NotNull(result);
        } // LoginTest

        // Source
        private static readonly object[] LoginTestSource = new[]
        {
            new object[]
            {
                new LoginCommand
                {
                    User = new UserModel
                    {
                        Login = "Admin",
                        Password = "12345"
                    }
                }
            }
        };
    }
}
