#nullable enable

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static partial class FilesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"files", @"Files endpoint commands.");
                         command.Subcommands.Add(FilesUploadFileCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}