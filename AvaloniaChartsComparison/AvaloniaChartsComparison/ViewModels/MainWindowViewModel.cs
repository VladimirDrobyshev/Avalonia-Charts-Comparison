using System;
using AvaloniaChartsComparison.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaChartsComparison.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private static readonly DataGenerator dataGenerator = new();
    
    private readonly Lazy<LiveChartsViewModel> liveChartsViewModel = new (() => new LiveChartsViewModel(dataGenerator));
    private readonly Lazy<MicrochartsViewModel> microchartsViewModel = new (() => new MicrochartsViewModel(dataGenerator));
    private readonly Lazy<OxyPlotViewModel> oxyPlotViewModel = new (() => new OxyPlotViewModel(dataGenerator));
    private readonly Lazy<ScottPlotViewModel> scottPlotViewModel = new (() => new ScottPlotViewModel(dataGenerator));
    private readonly Lazy<TeeChartViewModel> teeChartViewModel = new (() => new TeeChartViewModel(dataGenerator));
    
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
    [RelayCommand]
    void TeeChart() => ChartView = teeChartViewModel.Value;
}