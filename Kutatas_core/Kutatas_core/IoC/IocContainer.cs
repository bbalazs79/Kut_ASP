using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kutatas_core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Kutatas_core.IoC
{
    public static class Ioc
    {
        // public static ApplicationDbContext ApplicationDbContext => IocContainer.Provider.GetService<ApplicationDbContext>();
    }
    public static class IocContainer
    {
        public static ServiceProvider Provider { get; set; }
    }
}
