# Avalonia-Charts-Comparison
Comparison of open source charts for Avalonia.

## Chart Controls
* LiveCharts2 https://github.com/beto-rodriguez/LiveCharts2
* Microcharts https://github.com/AvaloniaCommunity/Avalonia.Microcharts
* OxyPlot https://github.com/oxyplot/oxyplot-avalonia
* ScottPlot https://github.com/ScottPlot/ScottPlot

## Comparison

### Cartesian Chart

Views        | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | Comment
:----------- | :---------: | :---------: | :-----: | :-------: | :------
Line         |      +      |             |         |           |
Bars         |      +      |             |         |           |
Stacked Area |      +      |             |         |           |
Range Area   |      -      |             |         |           | Можно попробовать заменить с помощью Stacked Area

Diagram             | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | Comment
:------------------ | :---------: | :---------: | :-----: | :-------: | :------
Secondary Axes      |      +      |             |         |           |
Logariphmic scale   |      +      |             |         |           |
Zoom/Scroll by axis |      -      |             |         |           |
Constant Lines      |      -      |             |         |           | Можно заменить обычной Line серией
Zoom/Scroll by axis |      -      |             |         |           |
Empty Points        |      +      |             |         |           |
ToolTips            |      -      |             |         |           |
Crosshair           |      -      |             |         |           | Тултип на максималках (не нужно точного попадания)

### Polar Chart

Features             | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | Comment
:------------------- | :---------: | :---------: | :-----: | :-------: | :------
Scatter Line         |      -      |             |         |           |
Scrolling/Zooming    |             |             |         |           |
ToolTips             |             |             |         |           |
Crosshair            |             |             |         |           |

### Smith Chart

Exists              | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | Comment
:------------------ | :---------: | :---------: | :-----: | :-------: | :------
Smith Chart         |      -      |             |         |           |

# Performance

Features                       | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | Comment
:----------------------------- | :---------: | :---------: | :-----: | :-------: | :------
4 cartesian lines - 1M each    |             |             |         |           |
100 cartesian lines - 10K each |             |             |         |           |
100 polar lines - 10K each     |             |             |         |           |
