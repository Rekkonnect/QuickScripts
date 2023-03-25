using Garyon.Extensions;
using Garyon.Functions;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
while (true)
    IterateDirectory();

static void IterateDirectory()
{
    ConsoleUtilities.WriteLineWithColor(@"Enter the path of the directory, or ""exit"" to exit:", ConsoleColor.Cyan);
    var line = ConsoleUtilities.ReadLineWithColor(ConsoleColor.Yellow)!;
    if (line is "exit")
        Environment.Exit(0);

    try
    {
        var baseDirectory = new DirectoryInfo(line!);

        var containedDirectories = baseDirectory.GetDirectories();
        foreach (var directory in containedDirectories)
        {
            foreach (var file in directory.GetFiles())
            {
                file.MoveUp(1);
            }
            directory.Delete();
        }

        ConsoleUtilities.WriteLineWithColor("Done\n", ConsoleColor.Green);
    }
    catch (Exception ex)
    {
        ConsoleUtilities.WriteExceptionInfo(ex);
    }
}
