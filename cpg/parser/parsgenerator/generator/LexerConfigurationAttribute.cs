﻿using System;
using System.Collections.Generic;
using System.Text;

namespace parser.parsergenerator.generator
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class LexerConfigurationAttribute : Attribute
    {
        
        public LexerConfigurationAttribute() {
            
        }
    }
}
