#nullable enable

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static partial class LyricsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"lyrics", @"Lyrics endpoint commands.");
                         command.Subcommands.Add(LyricsExtendLyricsCommandApiCommand.Create());
                         command.Subcommands.Add(LyricsGenerateLyricsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}