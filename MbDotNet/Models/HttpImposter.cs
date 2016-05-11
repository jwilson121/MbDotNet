﻿using System.Collections.Generic;
using MbDotNet.Enums;
using MbDotNet.Interfaces;
using Newtonsoft.Json;

namespace MbDotNet.Models
{
    public class HttpImposter : Imposter 
    {
        [JsonProperty("stubs")]
        public ICollection<HttpStub> Stubs { get; private set; }

        public HttpImposter(int port, string name) : base(port, MbDotNet.Enums.Protocol.Http, name)
        {
            Stubs = new List<HttpStub>();
        }

        public HttpStub AddStub()
        {
            var stub = new HttpStub();
            Stubs.Add(stub);
            return stub;
        }
    }
}
