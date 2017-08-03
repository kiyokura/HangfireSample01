using System.IO;

namespace MyJobsLib
{
  public class CustomJob : ICostomJob // ★ICostomJobの実装にする
  {
    // ★コンストラクタでIJobConfigurationの実装を受け取り保持することにする
    private IJobConfiguration JobConfiguration = null;

    public CustomJob(IJobConfiguration jobConfiguration)
    {
      JobConfiguration = jobConfiguration;
    }
    
    public void Execute(string message)
    {
      var fileName = string.Format("HangfireJob_{0}.txt", System.Guid.NewGuid());
      var filepath = Path.Combine(Path.GetTempPath(), fileName);
      using (var writer = new StreamWriter(filepath, true))
      {
        writer.WriteLine(message);

        // ★実行プロセス側から受け取った情報の接続文字列を使う……想定
        writer.WriteLine(JobConfiguration.ConnectionString);
      }
    }
  }
}
