using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAutoFocusBasicExample.Extensions
{
    public static class JSinteropFocusExtensions
    {
        public static ValueTask DoFocusAsync(this IJSRuntime jSRuntime,ElementReference elementReference)
        {
            return jSRuntime.InvokeVoidAsync("DoFocus", elementReference);
        }
    }
}
