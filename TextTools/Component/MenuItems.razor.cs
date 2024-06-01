using Microsoft.AspNetCore.Components;
using TextTools.Model;

namespace TextTools.Component
{
    public partial class MenuItems
    {
        [Parameter] public List<Tool> ToolsList { get; set; }= [];
        [Parameter] public string ToolHeading { get; set;}=string.Empty;
    }
}
