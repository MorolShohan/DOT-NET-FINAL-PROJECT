﻿using BLL.Services;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace TriUniversity.Auth
{
    public class ALoged : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;
            if (token == null)
            {
                actionContext.Response =
                        actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, new { message = "No token supply" });
            }
            else if (!SAuthService.IsTokenValid(token.ToString()))
            {
                actionContext.Response =
                 actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, new { message = "Token invalid or Expired" });

            }
            base.OnAuthorization(actionContext);

        }
    }
}