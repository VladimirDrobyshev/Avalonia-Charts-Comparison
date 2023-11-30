using System.Linq;
using Avalonia.Microcharts;
using AvaloniaChartsComparison.Models;

namespace AvaloniaChartsComparison.ViewModels;

public class MicrochartsViewModel : ChartViewModelBase
{
    public LineChart Chart { get; }

    public MicrochartsViewModel(DataGenerator dataGenerator) : base(dataGenerator)
    {
        Chart = new LineChart { Entries = dataGenerator.SmallXYSeriesValues[0].Select(d => new Entry { Value = (float)d }) };
    }
}