using System;
using AvaloniaChartsComparison.Models;
using ScottPlot.Avalonia;

namespace AvaloniaChartsComparison.ViewModels;

public class ScottPlotViewModel : ChartViewModelBase
{
    // Copied from ScottPlot v4
    private static (double[] xs, double[] ys) ConvertPolarCoordinates(double[] rs, double[] thetas)
    {
        double[] xs = new double[rs.Length];
        double[] ys = new double[rs.Length];

        for (int i = 0; i < rs.Length; i++)
        {
            double x = rs[i];
            double y = thetas[i];

            xs[i] = x * Math.Cos(y);
            ys[i] = x * Math.Sin(y);
        }

        return (xs, ys);
    }
    
    public ScottPlotViewModel(DataGenerator dataGenerator) : base(dataGenerator)
    {
    }
    
    public void FillLargeChart(AvaPlot chart)
    {
        foreach (var seriesValues in DataGenerator.LargeXYSeriesValues)
        {
            chart.Plot.Add.Signal(seriesValues);
        }
        chart.Refresh();
    }

    public void FillSmallChart(AvaPlot chart)
    {
        foreach (var seriesValues in DataGenerator.SmallXYSeriesValues)
        {
            chart.Plot.Add.Signal(seriesValues);
        }
        chart.Refresh();
    }

    public void FillPolarChart(AvaPlot chart)
    {
        foreach (var seriesValues in DataGenerator.PolarSeriesValues)
        {
            (double[] xs, double[] ys) = ConvertPolarCoordinates(seriesValues, DataGenerator.PolarSeriesArguments);
            chart.Plot.Add.Scatter(xs, ys);
        }
        chart.Refresh();
    }
}