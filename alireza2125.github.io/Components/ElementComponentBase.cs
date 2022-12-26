using Microsoft.AspNetCore.Components;

namespace alireza2125.github.io.Components;

public class ElementComponentBase : ComponentBase
{
    public Dictionary<string, object> AdditionalAttributes { get; set; } = new();
}
