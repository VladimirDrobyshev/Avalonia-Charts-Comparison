using System;
using Avalonia.Controls;
using AvaloniaChartsComparison.ViewModels;

namespace AvaloniaChartsComparison.Views;

public partial class ScottPlotView : UserControl
{
    public ScottPlotView()
    {
        InitializeComponent();
    }

    protected override void OnDataContextChanged(EventArgs e)
    {
        base.OnDataContextChanged(e);
        if (DataContext is ScottPlotViewModel viewModel)
        {
            viewModel.FillLargeChart(LargeSeriesChart);
            viewModel.FillSmallChart(SmallSeriesChart);
            viewModel.FillPolarChart(PolarSeriesChart);
        }
    }
}