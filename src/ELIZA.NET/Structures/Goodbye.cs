﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace ELIZA.NET.Structures
{
    [Serializable]
    public class Goodbye
    {
        [JsonProperty("message")]
        public string Message = null;

        [JsonProperty("script")]
        public string Script = null;

        public Goodbye(string message, string script)
        {
            this.Message = message;
            this.Script = script;
        }

        public Goodbye() { }

        public override string ToString()
        {
            return Message;
        }
    }
}
