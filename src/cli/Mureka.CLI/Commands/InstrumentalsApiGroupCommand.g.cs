#nullable enable

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static class InstrumentalsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"instrumentals", @"Instrumentals endpoint commands.");
                         command.Subcommands.Add(InstrumentalsGenerateInstrumentalCommandApiCommand.Create());
                         command.Subcommands.Add(InstrumentalsGetInstrumentalTaskCommandApiCommand.Create());
        return command;
    }
}