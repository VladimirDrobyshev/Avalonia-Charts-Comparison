using System.Collections.Generic;
using AvaloniaChartsComparison.Models;
using Steema.TeeChart.Styles;

namespace AvaloniaChartsComparison.ViewModels;

public class TeeChartViewModel : ChartViewModelBase
{
    public List<DataItem> LargeSeries { get; } = new();
    public List<DataItem> SmallSeries { get; } = new();
    
    public TeeChartViewModel(DataGenerator dataGenerator) : base(dataGenerator)
    {
        AddData(LargeSeries, dataGenerator.LargeXYSeriesValues);
        AddData(SmallSeries, dataGenerator.SmallXYSeriesValues);
    }

    private void AddData(List<DataItem> target, double[][] source)
    {
        foreach (var series in source)
        {
            for (int i = 0; i < series.Length; i++)
            {
                target.Add(new DataItem { X = i, Y = series[i] });
            }
        }
    }
}

public struct DataItem
{
    public double X { get; set; }
    public double Y { get; set; }
}