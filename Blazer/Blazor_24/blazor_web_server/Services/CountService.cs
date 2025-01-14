using System;

namespace blazor_web_server.Services;

public class CountService
{
    public int Count { get; set; } = 11111;

    public void InCrease()
    {
        Count++;
        NotifyStateChange();
    }

    public void DeCrease()
    {
        Count--;
        NotifyStateChange();
    }

    public event Action Onchange;

    public void NotifyStateChange() => Onchange?.Invoke();
}
