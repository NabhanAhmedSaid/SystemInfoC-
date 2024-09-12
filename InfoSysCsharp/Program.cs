string os_version = Environment.OSVersion.ToString();
System.Console.WriteLine($"OS : {os_version}");
string MachineName = Environment.MachineName.ToString();
System.Console.WriteLine($"MachineName : {MachineName}");
string UserName = Environment.UserName.ToString();
System.Console.WriteLine($"User Name : {UserName}");
string ProcessorCount = Environment.ProcessorCount.ToString();
System.Console.WriteLine($"ProcessorCount: {ProcessorCount}");
string NetVersion = Environment.Version.ToString();
System.Console.WriteLine($".Net Version : {NetVersion}");

