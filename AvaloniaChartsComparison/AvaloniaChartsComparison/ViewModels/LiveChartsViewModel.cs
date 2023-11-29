using System.Collections.Generic;
using AvaloniaChartsComparison.Models;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace AvaloniaChartsComparison.ViewModels;

public class LiveChartsViewModel : ChartViewModelBase
{
    private static SKColor[] Colors = { SKColors.Blue, SKColors.Red, SKColors.Green, SKColors.Yellow, SKColors.Magenta, SKColors.Aqua, SKColors.Brown };

    public ISeries[] LargeSeries { get; } = new ISeries[DataGenerator.LargeSeriesCount];
    public ISeries[] LargePoints { get; } = new ISeries[DataGenerator.SmallSeriesCount];
    public ISeries[] PolarSeries { get; } = new ISeries[DataGenerator.SmallSeriesCount];
    public List<Axis> LargePointsAxes { get; } = new()
    {
        new (),
        new LogaritmicAxis(10) { Position = AxisPosition.End }
    };

    public LiveChartsViewModel(DataGenerator dataGenerator) : base(dataGenerator)
    {
        for (int i = 0; i < DataGenerator.LargeSeriesCount; i++)
        {
            LargeSeries[i] = CreateLineSeries(dataGenerator.LargeXYSeriesValues[i], Colors[i]);
        }
        
        for (int i = 0; i < DataGenerator.SmallSeriesCount; i++)
        {
            LargePoints[i] = CreateLineSeries(dataGenerator.SmallXYSeriesValues[i], Colors[i % Colors.Length], i > DataGenerator.SmallSeriesCount / 2 ? 0 : 1);
        }
        
        for (int i = 0; i < DataGenerator.SmallSeriesCount; i++)
        {
            PolarSeries[i] = CreatePolarSeries(dataGenerator.SmallXYSeriesValues[i], Colors[i % Colors.Length], i > DataGenerator.SmallSeriesCount / 2 ? 0 : 1);
        }
    }

    private static LineSeries<double> CreateLineSeries(double[] values, SKColor color, int axis = 0)
    {
        return new LineSeries<double>
        {
            Values = values,
            Fill = null,
            GeometryStroke = null,
            GeometryFill = null,
            LineSmoothness = 0,
            Stroke = new SolidColorPaint(color) { StrokeThickness = 1 },
            ScalesYAt = axis
        };
    }
    
    private static PolarLineSeries<double> CreatePolarSeries(double[] values, SKColor color, int axis = 0)
    {
        return new PolarLineSeries<double>
        {
            Values = values,
            Fill = null,
            GeometryStroke = null,
            GeometryFill = null,
            LineSmoothness = 0,
            Stroke = new SolidColorPaint(color) { StrokeThickness = 1 },
            IsClosed = false
        };
    }
}
