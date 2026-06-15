#nullable enable

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static class LyricsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"lyrics", @"Lyrics endpoint commands.");
                         command.Subcommands.Add(LyricsExtendLyricsCommandApiCommand.Create());
                         command.Subcommands.Add(LyricsGenerateLyricsCommandApiCommand.Create());
        return command;
    }
}