#nullable enable

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(FilesApiGroupCommand.Create());
                         command.Subcommands.Add(InstrumentalsApiGroupCommand.Create());
                         command.Subcommands.Add(LyricsApiGroupCommand.Create());
                         command.Subcommands.Add(SongsApiGroupCommand.Create());
        return command;
    }
}