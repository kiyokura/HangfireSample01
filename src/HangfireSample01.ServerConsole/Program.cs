using Autofac;
using Hangfire;
using System;

namespace HangfireSample01.ServerConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      var constr = @"Data Source=localhost;Initial Catalog=HangfireJob;Integrated Security=True";
      GlobalConfiguration.Configuration.UseSqlServerStorage(constr);

      // ★コンテナに型を登録、Activatorに設定
      var builder = new ContainerBuilder();
      builder.RegisterType<JobConfiguration>().As<MyJobsLib.IJobConfiguration>();
      builder.RegisterType<MyJobsLib.CustomJob>().As<MyJobsLib.ICostomJob>();
      GlobalConfiguration.Configuration.UseAutofacActivator(builder.Build());

      using (var server = new BackgroundJobServer())
      {
        Console.WriteLine("Hangfire Server started. Press any key to exit...");
        Console.ReadKey();
      }
    }
  }
}
