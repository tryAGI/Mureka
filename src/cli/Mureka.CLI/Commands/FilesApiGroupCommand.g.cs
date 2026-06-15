#nullable enable

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static class FilesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"files", @"Files endpoint commands.");
                         command.Subcommands.Add(FilesUploadFileCommandApiCommand.Create());
        return command;
    }
}