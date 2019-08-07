using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.DoorHomeworkAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace SVDataServiceEx
{
    public class Startup
    {
        /// <summary>
        ///  This method gets called by the runtime. Use this method to add services to the container.
        ///  For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDoorRepository, DoorRepository>();
        }
    }
}
