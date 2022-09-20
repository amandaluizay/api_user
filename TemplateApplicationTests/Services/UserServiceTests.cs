using AutoMapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Application.Services;
using Template.Application.ViewModels;
using Template.Domain.Interfaces;
using Xunit;

namespace TemplateApplicationTests.Services
{
    public class UserServiceTests
    {
        private UserService userService;
        public UserServiceTests()
        {
            userService = new UserService(new Mock<IUserRepository>().Object, new Mock<IMapper>().Object);
        }

        [Fact]
        public void MetodoPost_EnviaID_valido()
        {
            var result = userService.Post(new UserViewModel { Id = Guid.NewGuid() });
            Assert.False(result);
        }
    }
}
