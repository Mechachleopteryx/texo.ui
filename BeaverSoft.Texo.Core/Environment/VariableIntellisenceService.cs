﻿using System;
using System.Collections.Generic;
using BeaverSoft.Texo.Core.View;

namespace BeaverSoft.Texo.Core.Environment
{
    public class VariableIntellisenceService : IVariableIntellisenceService
    {
        private readonly IEnvironmentService environment;

        public VariableIntellisenceService(IEnvironmentService environment)
        {
            this.environment = environment;
        }

        public IEnumerable<IItem> Help(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                yield break;
            }

            foreach (var variable in environment.GetVariables())
            {
                if (!variable.Key.StartsWith(input, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                yield return Item.Intellisence(variable.Key, "variable", variable.Value ?? "[NULL]");
            }
        }
    }
}
