using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PersonalPhotos.Controllers;

namespace PersonalPhotos.Test
{
    public class LoginTest
    {
        private readonly LoginsController _controller;
        private readonly Mock<ILogins> _login;
        private readonly Mock<IHttpContextAccessor> _httpContextAccessor;

        public LoginTest()
        {
            _login = new Mock<ILogins>();

            Mock<ISession> session = new Mock<ISession>();
            Mock<HttpContext> httpContext = new Mock<HttpContext>();
            httpContext.Setup(x => x.Session).Returns(session.Object);
            _httpContextAccessor = new Mock<IHttpContextAccessor>();
            _httpContextAccessor.Setup(x => x.HttpContext).Returns(httpContext.Object);

            _controller = new LoginsController(_login.Object, _httpContextAccessor.Object);
        }

        [Fact]
        public void Index_GivenOrReturnUrl_ReturnLoginView()
        {
            var result = _controller.Index() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal("Login", result.ViewName);
        }
    }
}