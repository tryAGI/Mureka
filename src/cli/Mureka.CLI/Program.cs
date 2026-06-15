#nullable enable

using System.CommandLine;
using Mureka.CLI;
using Mureka.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the Mureka SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(FilesApiGroupCommand.Create());
rootCommand.Subcommands.Add(InstrumentalsApiGroupCommand.Create());
rootCommand.Subcommands.Add(LyricsApiGroupCommand.Create());
rootCommand.Subcommands.Add(SongsApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);