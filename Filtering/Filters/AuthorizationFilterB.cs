﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtering.Filters
{
    public class AuthorizationFilterB : FilterAttribute, IAuthorizationFilter
    {
        private readonly string _scope;
        public AuthorizationFilterB(string scope)
        {
            _scope = scope;
        }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            Debug.WriteLine("Action {0} Filter {1} Scope {2}", filterContext.ActionDescriptor.ActionName, "AuthorizationFilterBBBB", _scope);
        }
    }
}