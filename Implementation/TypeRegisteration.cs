﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Implementation;
using Microsoft.Practices.Unity;

namespace Implementation
{
    public static class TypeRegisteration
    {
        public static void RegisterType(IUnityContainer unityContainer)
        {
           Repository.TypeRegisteration.RegisterType(unityContainer);
            unityContainer.RegisterType<IProductService, ProductService>();
        }

    }
}
