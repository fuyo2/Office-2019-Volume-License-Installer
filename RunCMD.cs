using System.Diagnostics;

namespace OfficeEasyInstaller
{
    class RunCMD
    {
        public static void SetUp()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/K setup.exe /configure configuation.xml";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
        }
    }
}
