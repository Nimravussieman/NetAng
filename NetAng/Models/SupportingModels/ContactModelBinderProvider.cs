using Microsoft.AspNetCore.Mvc.ModelBinding;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models.SupportingModels
{
    public class ContactModelBinderProvider : IModelBinderProvider
    {
        private readonly IModelBinder binder = new ContactModelBinder();

        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            return context.Metadata.ModelType == typeof(Contact) ? binder : null;
        }
    }
}