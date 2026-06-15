#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static partial class SongsGenerateSongCommandApiCommand
{
    private static Option<string> Lyrics { get; } = new(
        name: @"--lyrics")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::Mureka.GenerateSongRequestModel?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
    };

    private static Option<int?> N { get; } = new(
        name: @"--n")
    {
        Description = @"",
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"",
    };

    private static Option<string?> ReferenceId { get; } = new(
        name: @"--reference-id")
    {
        Description = @"",
    };

    private static Option<string?> VocalId { get; } = new(
        name: @"--vocal-id")
    {
        Description = @"",
    };

    private static Option<string?> MelodyId { get; } = new(
        name: @"--melody-id")
    {
        Description = @"",
    };

    private static Option<string?> InstrumentalId { get; } = new(
        name: @"--instrumental-id")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Mureka.TaskResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Mureka.TaskResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"generate-song", @"Generate a complete song");
                        command.Options.Add(Lyrics);
                        command.Options.Add(Model);
                        command.Options.Add(N);
                        command.Options.Add(Prompt);
                        command.Options.Add(ReferenceId);
                        command.Options.Add(VocalId);
                        command.Options.Add(MelodyId);
                        command.Options.Add(InstrumentalId);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Mureka.GenerateSongRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Mureka.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var lyrics = parseResult.GetRequiredValue(Lyrics);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var n = CliRuntime.WasSpecified(parseResult, N) ? parseResult.GetValue(N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var referenceId = CliRuntime.WasSpecified(parseResult, ReferenceId) ? parseResult.GetValue(ReferenceId) : (__requestBase is { } __ReferenceIdBaseValue ? __ReferenceIdBaseValue.ReferenceId : default);
                        var vocalId = CliRuntime.WasSpecified(parseResult, VocalId) ? parseResult.GetValue(VocalId) : (__requestBase is { } __VocalIdBaseValue ? __VocalIdBaseValue.VocalId : default);
                        var melodyId = CliRuntime.WasSpecified(parseResult, MelodyId) ? parseResult.GetValue(MelodyId) : (__requestBase is { } __MelodyIdBaseValue ? __MelodyIdBaseValue.MelodyId : default);
                        var instrumentalId = CliRuntime.WasSpecified(parseResult, InstrumentalId) ? parseResult.GetValue(InstrumentalId) : (__requestBase is { } __InstrumentalIdBaseValue ? __InstrumentalIdBaseValue.InstrumentalId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Songs.GenerateSongAsync(
                                    lyrics: lyrics,
                                    model: model,
                                    n: n,
                                    prompt: prompt,
                                    referenceId: referenceId,
                                    vocalId: vocalId,
                                    melodyId: melodyId,
                                    instrumentalId: instrumentalId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Mureka.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}