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

      using (var server = new BackgroundJobServer())
      {
        Console.WriteLine("Hangfire Server started. Press any key to exit...");
        Console.ReadKey();
      }
    }
  }
}
