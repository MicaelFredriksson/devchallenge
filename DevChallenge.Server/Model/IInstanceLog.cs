﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DevChallenge.Server.Model
{
    public interface IInstanceLog
    {
        IInstance Instance { get; }
        void Start();
        void Finish(XElement finishlog);
        void SetScore(IAgent agent, int? score);
    }
}
