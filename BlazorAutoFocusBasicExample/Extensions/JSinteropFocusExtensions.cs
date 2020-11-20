using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAutoFocusBasicExample.Extensions
{
    /// <summary>
    /// 利用myScript.js裡面寫的DoFocus方法，來實現利用JSRuntime達到focus特定元件的方法
    /// </summary>
    public static class JSinteropFocusExtensions
    {
        public static ValueTask DoFocusAsync(this IJSRuntime jSRuntime,ElementReference elementReference)
        {
            return jSRuntime.InvokeVoidAsync("DoFocus", elementReference);
        }
    }
}
