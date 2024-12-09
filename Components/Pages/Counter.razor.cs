using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp1.Components.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private string text = string.Empty;
        private void IncrementCount()
        {
            currentCount++;
        }
        private void Onclick(MouseEventArgs e)
        {
            text = "";
        }
    }
}