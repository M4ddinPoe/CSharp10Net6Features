﻿using System;

namespace CSharp10Features.AttributesSupportGenerics;

public class OldAttribute : Attribute
{
    public OldAttribute(Type type)
    {

    }
}

public class NewAttribute<T> : Attribute
{
    public T MyType { get; set; }
}