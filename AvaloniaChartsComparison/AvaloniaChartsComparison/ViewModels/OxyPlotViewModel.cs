using AvaloniaChartsComparison.Models;
using OxyPlot;
using OxyPlot.Series;

namespace AvaloniaChartsComparison.ViewModels;

public class OxyPlotViewModel : ChartViewModelBase
{
    public PlotModel LargeSeries { get; }
    public PlotModel SmallSeries { get; }
    public PlotModel PolarSeries { get; }

    public OxyPlotViewModel(DataGenerator dataGenerator) : base(dataGenerator)
    {
        LargeSeries = CreateCartesianModel(dataGenerator.LargeXYSeriesValues);
        SmallSeries = CreateCartesianModel(dataGenerator.SmallXYSeriesValues);
        PolarSeries = CreatePolarModel(dataGenerator.PolarSeriesValues, dataGenerator.PolarSeriesArguments);
    }

    private PlotModel CreateCartesianModel(double[][] values )
    {
        var result = new PlotModel { Title = $"{values.Length} series with {values[0].Length} points each" };

        foreach (var seriesValues in values)
        {
            var series = new LineSeries { StrokeThickness = 1, LineJoin = LineJoin.Bevel, LineStyle = LineStyle.Solid, MarkerType = MarkerType.None };
            for (int j = 0; j < seriesValues.Length; j++)
            {
                series.Points.Add(new DataPoint(j, seriesValues[j]));
            }
            result.Series.Add(series);
        }

        return result;
    }
    
    private PlotModel CreatePolarModel(double[][] values, double[] arguments)
    {
        var result = new PlotModel { Title = $"{values.Length} series with {values[0].Length} points each", PlotType = PlotType.Polar };

        foreach (var seriesValues in values)
        {
            var series = new LineSeries { StrokeThickness = 1, LineJoin = LineJoin.Bevel, LineStyle = LineStyle.Solid, MarkerType = MarkerType.None };
            for (int j = 0; j < seriesValues.Length; j++)
            {
                series.Points.Add(new DataPoint(arguments[j], seriesValues[j]));
            }
            result.Series.Add(series);
        }

        return result;
    }
}
