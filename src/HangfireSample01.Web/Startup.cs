using Hangfire;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HangfireSample01.Web.Startup))]

namespace HangfireSample01.Web
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      var constr = @"Data Source=localhost;Initial Catalog=HangfireJob;Integrated Security=True";
      GlobalConfiguration.Configuration.UseSqlServerStorage(constr);

      app.UseHangfireDashboard();
    }
  }
}
