using System.IO;

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
