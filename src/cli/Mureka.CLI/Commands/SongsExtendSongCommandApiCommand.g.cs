#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Mureka.CLI.Commands;

internal static partial class SongsExtendSongCommandApiCommand
{
    private static Option<string?> SongId { get; } = new(
        name: @"--song-id")
    {
        Description = @"",
    };

    private static Option<string?> UploadAudioId { get; } = new(
        name: @"--upload-audio-id")
    {
        Description = @"",
    };

    private static Option<string?> Lyrics { get; } = new(
        name: @"--lyrics")
    {
        Description = @"",
    };

    private static Option<long> ExtendAt { get; } = new(
        name: @"--extend-at")
    {
        Description = @"",
        Required = true,
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
        var command = new Command(@"extend-song", @"Extend an existing song");
                        command.Options.Add(SongId);
                        command.Options.Add(UploadAudioId);
                        command.Options.Add(Lyrics);
                        command.Options.Add(ExtendAt);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Mureka.ExtendSongRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Mureka.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var songId = CliRuntime.WasSpecified(parseResult, SongId) ? parseResult.GetValue(SongId) : (__requestBase is { } __SongIdBaseValue ? __SongIdBaseValue.SongId : default);
                        var uploadAudioId = CliRuntime.WasSpecified(parseResult, UploadAudioId) ? parseResult.GetValue(UploadAudioId) : (__requestBase is { } __UploadAudioIdBaseValue ? __UploadAudioIdBaseValue.UploadAudioId : default);
                        var lyrics = CliRuntime.WasSpecified(parseResult, Lyrics) ? parseResult.GetValue(Lyrics) : (__requestBase is { } __LyricsBaseValue ? __LyricsBaseValue.Lyrics : default);
                        var extendAt = parseResult.GetRequiredValue(ExtendAt);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Songs.ExtendSongAsync(
                                    songId: songId,
                                    uploadAudioId: uploadAudioId,
                                    lyrics: lyrics,
                                    extendAt: extendAt,
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