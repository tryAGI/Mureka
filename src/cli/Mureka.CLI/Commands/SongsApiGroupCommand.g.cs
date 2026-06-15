#nullable enable

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static class SongsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"songs", @"Songs endpoint commands.");
                         command.Subcommands.Add(SongsDescribeSongCommandApiCommand.Create());
                         command.Subcommands.Add(SongsExtendSongCommandApiCommand.Create());
                         command.Subcommands.Add(SongsGenerateSongCommandApiCommand.Create());
                         command.Subcommands.Add(SongsGetSongTaskCommandApiCommand.Create());
                         command.Subcommands.Add(SongsRecognizeSongCommandApiCommand.Create());
                         command.Subcommands.Add(SongsStemSongCommandApiCommand.Create());
        return command;
    }
}