using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace myApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app){

            app.UseMiddleware<MyMiddleware>();

            // //Middleware add header
            // app.Use(async (context, next) => {
            //     context.Response.Headers.Add("Middleware","APRENDENDO");
            //     await next.Invoke();
            // });

            app.Run(context => context.Response.WriteAsync("Olá mundo 2 | "));
        }
    }
}