using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PersonalPhotos.Controllers;
using PersonalPhotos.Models;
using System.IO;
using System.Net.Mime;
using System.Text;

namespace PersonalPhotos.Test
{
    public class PhotoTest
    {
        [Fact]
        public async void Photo_GivenPhoto_ReturnReditectAction()
        {
            ISession session = new MockHttpSession();
            session.Set("User", Encoding.UTF8.GetBytes("test@testing.com"));
            var value = session.GetString("User");
            HttpContext context = Mock.Of<HttpContext>(x => x.Session == session);
            HttpContextAccessor httpContextAccessor = Mock.Of<HttpContextAccessor>(x => x.HttpContext == context);

            IKeyGenerator keyGenerator = Mock.Of<IKeyGenerator>();
            IPhotoMetaData photoMetaData = Mock.Of<IPhotoMetaData>();
            IFileStorage fileStorage = Mock.Of<IFileStorage>();

            //var formFile = Mock.Of<Microsoft.AspNetCore.Http.IFormFile>();

            Stream stream = new MemoryStream();
            string fileName = "example.jpg";
            string contentType = "image/jpeg";
            long fileLength = stream.Length;
            var formFile = new FormFile(stream, 0, fileLength, "file", fileName)
            {
                Headers = new HeaderDictionary(),
                ContentType = contentType
            };

            var model = Mock.Of<PhotoUploadViewModel>(x => x.File == formFile);

            PhotosController photosController = new PhotosController(keyGenerator, httpContextAccessor, photoMetaData, fileStorage);

            // Act
            var result = await photosController.Upload(model) as RedirectToActionResult;

            // Assert
            Assert.Equal("Display", result.ActionName);
        }
    }
}
