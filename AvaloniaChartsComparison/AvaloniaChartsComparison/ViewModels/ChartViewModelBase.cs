using AvaloniaChartsComparison.Models;

namespace AvaloniaChartsComparison.ViewModels;

public abstract class ChartViewModelBase : ViewModelBase
{
    public DataGenerator DataGenerator { get; }

    protected ChartViewModelBase(DataGenerator dataGenerator)
    {
        DataGenerator = dataGenerator;
    }
}