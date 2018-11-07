using System;
using System.Web.Mvc;
using System.Linq;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWebAPI.Controllers;
using MovieModel;

namespace MovieWebAPI.Tests.Controllers
{
    [TestClass]
    public class MovieControllerTest
    {
        [TestMethod]
        public void GetMovies()
        {
            // Arrange
            MovieController controller = new MovieController();

            // Act
            IQueryable<Movie> result = controller.GetMovies() as IQueryable<Movie>;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetMovie()
        {
            // Arrange
            MovieController controller = new MovieController();

            // Act
            IHttpActionResult result = controller.GetMovie(1) as IHttpActionResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PutMovie()
        {
            // Arrange
            MovieController controller = new MovieController();

            // Act
            Movie m = new Movie();
            m.Id = 1;
            m.Title = "X-Men " + DateTime.Now.ToString();
            m.Year = 2010;
            m.RatingId = 2;
            IHttpActionResult result = controller.PutMovie(1,m) as IHttpActionResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PostMovie()
        {
            // Arrange
            MovieController controller = new MovieController();

            // Act
            Movie m = new Movie();
            m.Title = "X-Men " + DateTime.Now.ToString();
            m.Year = 2018;
            m.RatingId = 4;
            IHttpActionResult result = controller.PostMovie(m) as IHttpActionResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DeleteMovie()
        {
            // Arrange
            MovieController controller = new MovieController();

            // Act
            IHttpActionResult result = controller.DeleteMovie(3) as IHttpActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
