﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace Umbraco.Inception.BL
{
    public interface CustomDataType
    {
        IDictionary<string, PreValue> PreValues { get; }
    }
}