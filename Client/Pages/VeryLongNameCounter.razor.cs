using Microsoft.AspNetCore.Components;

namespace RazorRenamingBugExample.Client.Pages
{
    public partial class VeryLongNameCounter : ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount() {
            currentCount++;
        }
    }
}
