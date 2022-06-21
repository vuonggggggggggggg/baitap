
using Microsoft.AspNet.Identity;
using PhanThaiVuong_BigSchool.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Http;

namespace PhanThaiVuong_BigSchool.Controllers.api
{
    public class CoursesController : ApiController
    {
        ApplicationDbContext _dbContext { get; set; }

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbContext.Courses.Single(c => c.Id == id && c.LecturerId == userId);


            if (course.IsCanceled)
            {
                return NotFound();
            }

            course.IsCanceled = true;

            _dbContext.SaveChanges();

            return Ok();

        }

        private IHttpActionResult Ok()
        {
            throw new NotImplementedException();
        }

        private IHttpActionResult NotFound()
        {
            throw new NotImplementedException();
        }
    }




}
//loi ne