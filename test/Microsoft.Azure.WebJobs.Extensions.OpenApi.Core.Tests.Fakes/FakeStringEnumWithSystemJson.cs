using System.Runtime.Serialization;
using System.Text.Json.Serialization;

using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;

namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Tests.Fakes
{
    /// <summary>
    /// This specifies fake enum values as string, but using System.Text.Json rather than Newtonsoft.Json.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FakeStringEnumWithSystemJson
    {
        [Display("lorem")]
        StringValue1,

        [EnumMember(Value = "ipsum")]
        StringValue2,

        [EnumMember(Value = "dolor")]
        [Display("sit")]
        StringValue3,

        StringValue4,
    }
}
