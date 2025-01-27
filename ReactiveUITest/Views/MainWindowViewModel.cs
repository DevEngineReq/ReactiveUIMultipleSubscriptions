using System.Diagnostics;
using System.Reactive;
using ReactiveUI;

namespace ReactiveUiTest.Views;

public class MainWindowViewModel
{
    private readonly List<BasicViewModel> cache = [];
    private ReactiveProperty<Unit> Property { get; } = new();

    public int SubscriberCount { get; }
    public long StartupTime { get; }

    public MainWindowViewModel()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        for (var i = 0; i < 1000; i++)
        {
            this.cache.Add(new BasicViewModel(this.Property));
        }

        stopwatch.Stop();

        this.StartupTime = stopwatch.ElapsedMilliseconds;
        this.SubscriberCount = this.cache.Count;
    }

    private class BasicViewModel
    {
        public BasicViewModel(IObservable<Unit> observable)
        {
            observable.Subscribe();
        }
    }
}