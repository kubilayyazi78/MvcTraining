using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace ModelBinding.ModelBinders
{
    public class CustomDefaultModelBinder : System.Web.Mvc.DefaultModelBinder
    {
       // protected override void OnPropertyValidated(ControllerContext controllerContext , System.Web.ModelBinding.ModelBindingContext bindingContext,PropertyDescriptor propertyDescriptor,object value)
        //{
          //  bindingContext.ModelState.Clear();
        //}
    } 
}