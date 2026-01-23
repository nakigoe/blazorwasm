using System.Text.Json; 
using System.Text.Json.Serialization;
using nakigoe.Models;

namespace nakigoe.Serialization;

/// <summary>
/// The source generator uses this type as a marker to discover which models need serialization metadata.
/// The actual implementation is emitted into compiler-generated files at build time, so the class body intentionally stays empty.
/// </summary>
[JsonSourceGenerationOptions(JsonSerializerDefaults.Web)]
[JsonSerializable(typeof(WeatherForecast[]))]
public sealed partial class AppJsonContext : JsonSerializerContext;
