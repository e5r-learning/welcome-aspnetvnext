using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace E5R.Learning.WelcomeAspNet
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async context => {
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("Hello world web!");
                await context.Response.WriteAsync("\n" + context.Request.Path);
            });
        }
    }
}