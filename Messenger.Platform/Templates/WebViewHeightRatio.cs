﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Messenger.Templates
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum  WebViewHeightRatio
    {
        [EnumMember(Value = "compact")]
        Compact,

        [EnumMember(Value = "tail")]
        Tail,

        [EnumMember(Value = "full")]
        Full
    }
}