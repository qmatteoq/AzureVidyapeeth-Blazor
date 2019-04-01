using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorLibrary
{
    public class ExampleJsInterop
    {
        private readonly IJSRuntime _jsRuntime;
        
        public ExampleJsInterop(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }

        public Task<string> Prompt(string message)
        {
            // Implemented in exampleJsInterop.js
            return _jsRuntime.InvokeAsync<string>(
                "exampleJsFunctions.showPrompt",
                message);
        }
    }
}
