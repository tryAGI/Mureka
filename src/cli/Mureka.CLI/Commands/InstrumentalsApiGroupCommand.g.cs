#nullable enable

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static partial class InstrumentalsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"instrumentals", @"Instrumentals endpoint commands.");
                         command.Subcommands.Add(InstrumentalsGenerateInstrumentalCommandApiCommand.Create());
                         command.Subcommands.Add(InstrumentalsGetInstrumentalTaskCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}