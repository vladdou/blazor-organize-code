using Microsoft.AspNetCore.Components;

namespace ThreeWays.Pages
{
    public class CounterBase: ComponentBase
    {
        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}