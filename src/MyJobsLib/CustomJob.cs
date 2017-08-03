using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJobsLib
{
  public class CustomJob
  {
    public void Execute(string message)
    {
      var fileName = string.Format("HangfireJob_{0}.txt", System.Guid.NewGuid());
      var filepath = Path.Combine(Path.GetTempPath(), fileName);
      using (var writer = new StreamWriter(filepath, true))
      {
        writer.WriteLine(message);
      }
    }
  }
}
