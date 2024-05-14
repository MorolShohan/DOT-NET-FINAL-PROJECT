using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TriUniversity.Auth;

namespace CourseProject.Controllers
{
    public class AdminController : ApiController
    {
        [HttpPost]
        [Route("api/admin/create")]
        public HttpResponseMessage CreateAdmin([FromBody] AdminDTO adminDto)
        {
            try
            {

                var data = AdminService.CreateAdmin(adminDto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

        }
        [HttpGet]
        [Route("api/admin/Getadmin")]
        public HttpResponseMessage GetAdmin()
        {
            try
            {

                var data = AdminService.GetAdmin();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

        }
        [HttpGet]
        [Route("api/admin/{id}")]
        public HttpResponseMessage GetAdmin(int id)
        {
            try
            {

                var data = AdminService.GetAdmin(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

        }
        [HttpPost]
        [Route("api/admin/login")]
        public HttpResponseMessage Login([FromBody] AdminDTO adminDto)
        {
            try
            {
                var res = AdminAuthService.Authenticatee(adminDto.Email, adminDto.Password);

                if (res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "Admin not found" });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/admin/logout")]
        public HttpResponseMessage Logout()
        {
            try
            {

                var token = HttpContext.Current.Request.Headers["Authorization"];

                if (token == null)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Token not provided in the header" });
                }

                var isLoggedOut = AdminAuthService.Logout(token);

                if (isLoggedOut)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Logout successful" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "Token not found or unable to logout" });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        //student post manage
        [ALoged]
        [HttpGet]
        [Route("api/admin/post/{postid}")]
        public HttpResponseMessage Getpostbyid(int postid)
        {
            try
            {

                var data = AdminService.GetPost(postid);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "post not found");
                }

            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);

            }
        }


        [ALoged]
        [HttpDelete]
        [Route("api/admin/post/delete/{id}")]
        public HttpResponseMessage DeletePost(int id)
        {
            try
            {
                var success = AdminService.DeletePost(id);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Post deleted successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Post not found.");
                }
            }
            catch
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "An error occurred while processing the request.");
            }
        }

        [ALoged]
        [HttpPut]
        [Route("api/admin/post/approve/{id}")]
        public HttpResponseMessage ApprovePost(int id)
        {
            try
            {
                var updatedPost = AdminService.UpdatePostApproval(id);
                if (updatedPost != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, updatedPost);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Post not found.");
                }
            }
            catch
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "An error occurred while processing the request.");
            }
        }


        [ALoged]
        [HttpGet]
        [Route("api/admin/post/approve")]
        public HttpResponseMessage GetApprovePosts()
        {
            try
            {

                var data = AdminService.GetApprovePosts();
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "post not found");
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);

            }
        }

        [ALoged]
        [HttpGet]
        [Route("api/admin/post/notapprove")]
        public HttpResponseMessage GetUnApprovePosts()
        {
            try
            {

                var data = AdminService.GetNotApprovePosts();
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "post not found");
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);

            }
        }


        [ALoged]
        [HttpGet]
        [Route("api/admin/post/count")]
        public HttpResponseMessage GetPostCountPerID()
        {
            try
            {
                var data = AdminService.GetPostRange();

                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Post not found."); // Return 404 if no data is found
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "An error occurred while processing the request.");
            }
        }

        [ALoged]
        [HttpGet]
        [Route("api/admin/student/{id}")]
        public HttpResponseMessage GetStudentbyId(int id)
        {
            try
            {

                var data = AdminService.GetStudent(id);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "student not found");
                }

            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);

            }


        }


        [ALoged]
        [HttpDelete]
        [Route("api/admin/Student/delete/{id}")]
        public HttpResponseMessage DeleteStudent(int id)
        {
            try
            {
                var success = AdminService.DeletePost(id);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Student deleted successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Student not found.");
                }
            }
            catch
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "An error occurred while processing the request.");
            }
        }

        [ALoged]
        [HttpGet]
        [Route("api/admin/Student/list/{id}")]
        public HttpResponseMessage ApproveStudent(int id)
        {
            try
            {
                var updatedPost = AdminService.UpdateStudentApproval(id);
                if (updatedPost != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, updatedPost);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Student not found.");
                }
            }
            catch
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "An error occurred while processing the request.");
            }
        }

        [ALoged]
        [HttpGet]
        [Route("api/admin/student/range")]
        public HttpResponseMessage GetStudentAgeRange()
        {
            try
            {
                var data = AdminService.GetStudentAgeRange();

                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Student not found."); // Return 404 if no data is found
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "An error occurred while processing the request.");
            }
        }








    }
}

