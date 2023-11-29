using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaChartsComparison.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly Lazy<LiveChartsViewModel> liveChartsViewModel = new (() => new LiveChartsViewModel());
    private readonly Lazy<MicrochartsViewModel> microchartsViewModel = new (() => new MicrochartsViewModel());
    private readonly Lazy<OxyPlotViewModel> oxyPlotViewModel = new (() => new OxyPlotViewModel());
    private readonly Lazy<ScottPlotViewModel> scottPlotViewModel = new (() => new ScottPlotViewModel());
    
    [ObservableProperty]
    private ChartViewModelBase chartView;

    [RelayCommand]
    void LiveCharts() => ChartView = liveChartsViewModel.Value;
    [RelayCommand]
    void Microcharts() => ChartView = microchartsViewModel.Value;
    [RelayCommand]
    void OxyPlot() => ChartView = oxyPlotViewModel.Value;
    [RelayCommand]
    void ScottPlot() => ChartView = scottPlotViewModel.Value;
}