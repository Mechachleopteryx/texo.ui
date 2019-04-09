﻿using System.Collections.Generic;
using BeaverSoft.Texo.Core.Configuration;

namespace BeaverSoft.Texo.Core.Input.InputTree
{
    public interface IInputTreeBuilder
    {
        InputTree Build(IEnumerable<Query> commands, string defaultCommandKey);
    }
}