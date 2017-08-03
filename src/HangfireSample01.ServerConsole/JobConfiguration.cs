namespace HangfireSample01.ServerConsole
{
  public class JobConfiguration : MyJobsLib.IJobConfiguration
  {
    public string ConnectionString { get; set; }

    public JobConfiguration()
    {
      ConnectionString = "接続文字列だよ";
    }
  }
}
