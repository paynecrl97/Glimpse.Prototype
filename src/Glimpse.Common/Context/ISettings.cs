﻿using System;

namespace Glimpse
{
    // TODO: Should probably be made available off ContextData 
    //       and not just HttpContext.
    public interface ISettings
    {
        Func<IContext, bool> ShouldProfile { get; }
    }
}