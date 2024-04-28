using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PersonalPhotos.Controllers;
using PersonalPhotos.Models;

namespace PersonalPhotos.Test
{
    public class LoginTest
    {
        [Fact]
        public void Index_GivenOrReturnUrl_ReturnLoginView()
        {
            // Arrange
            ILogins logins = Mock.Of<ILogins>();
            IHttpContextAccessor httpContextAccessor = Mock.Of<IHttpContextAccessor>();
            LoginsController loginsController = new LoginsController(logins, httpContextAccessor);

            // Act
            var result = loginsController.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Login", result.ViewName);
        }

        [Fact]
        public async void Login_GivenModelStateInvalid_ReturnLoginView()
        {
            // Arrange
            ILogins logins = Mock.Of<ILogins>();

            ISession session = Mock.Of<ISession>();
            HttpContext httpContext = Mock.Of<HttpContext>(x => x.Session == session);
            IHttpContextAccessor httpContextAccessor = Mock.Of<IHttpContextAccessor>(x => x.HttpContext == httpContext);

            LoginsController loginsController = new LoginsController(logins, httpContextAccessor);
            loginsController.ModelState.AddModelError("Test", "Test");

            LoginViewModel loginViewModel = Mock.Of<LoginViewModel>();
            
            // Act
            var result = await loginsController.Login(loginViewModel) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Login", result.ViewName);
        }

        [Fact]
        public async void Login_GivenCorrectCredentials_RedirectToDisplayAction()
        {
            // Arrange
            ISession session = Mock.Of<ISession>();
            HttpContext httpContext = Mock.Of<HttpContext>(x => x.Session == session);
            IHttpContextAccessor httpContextAccessor = Mock.Of<IHttpContextAccessor>(x => x.HttpContext == httpContext);

            LoginViewModel loginViewModel = Mock.Of<LoginViewModel>(x => x.Email == "test@testing.com" && x.Password == "123");
            User user = new() { Email = "test@testing.com", Password = "123" };

            Mock<ILogins> logins = new Mock<ILogins>();
            logins.Setup(x => x.GetUser(It.IsAny<string>())).ReturnsAsync(user);
            
            LoginsController loginsController = new LoginsController(logins.Object, httpContextAccessor);

            // Act
            var result = await loginsController.Login(loginViewModel) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Photos", result.ControllerName);
            Assert.Equal("Display", result.ActionName);
        }

        [Fact]
        public async void Login_GivenInvalidCredentials_RedirectToDisplayAction()
        {
            // Arrange
            ISession session = Mock.Of<ISession>();
            HttpContext httpContext = Mock.Of<HttpContext>(x => x.Session == session);
            IHttpContextAccessor httpContextAccessor = Mock.Of<IHttpContextAccessor>(x => x.HttpContext == httpContext);

            LoginViewModel loginViewModel = Mock.Of<LoginViewModel>(x => x.Email == "test@testing.com" && x.Password == "123");
            User user = new() { Email = "test@testing.com", Password = "1234" };

            Mock<ILogins> logins = new Mock<ILogins>();
            logins.Setup(x => x.GetUser(It.IsAny<string>())).ReturnsAsync(user);

            LoginsController loginsController = new LoginsController(logins.Object, httpContextAccessor);

            // Act
            var result = await loginsController.Login(loginViewModel) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Login", result.ViewName);
        }
    }
}