﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern.Expectation
{
    public interface IExpectSurnamePersonBuilder
    {
        IExpectPrimaryContactPersonBuilder WithSurname(string surname);
    }
}
