using Talkative.Application;
using Talkative.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
   builder.Services.AddControllers();

   builder.Services
       .AddApplication()
       .AddInfrastructure();
}


var app = builder.Build();
{

   app.UseAuthorization();

   app.MapControllers();

   app.Run();

}


