#nullable enable

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static partial class SongsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"songs", @"Songs endpoint commands.");
                         command.Subcommands.Add(SongsDescribeSongCommandApiCommand.Create());
                         command.Subcommands.Add(SongsExtendSongCommandApiCommand.Create());
                         command.Subcommands.Add(SongsGenerateSongCommandApiCommand.Create());
                         command.Subcommands.Add(SongsGetSongTaskCommandApiCommand.Create());
                         command.Subcommands.Add(SongsRecognizeSongCommandApiCommand.Create());
                         command.Subcommands.Add(SongsStemSongCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}