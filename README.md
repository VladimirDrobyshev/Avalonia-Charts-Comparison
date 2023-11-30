# Avalonia-Charts-Comparison
Comparison of open source charts for Avalonia.

## Chart Controls

### OpenSource

* [LiveCharts2](https://github.com/beto-rodriguez/LiveCharts2) - Презентационные чарты, много анимаций, мало фич, не предназначены для работы с большими данными. Blazor-like API. Skia based.
* [Microcharts](https://github.com/AvaloniaCommunity/Avalonia.Microcharts) Нет nuget пакета, порт под Avalonia выглядит заброшенным: Net Core 3, Avalonia 10. В целом не работоспособен.
* [OxyPlot](https://github.com/oxyplot/oxyplot-avalonia) Богатый функционал, неплохая производительность для одиночной серии, старомодные. Дока старая, примеров много.
* [ScottPlot](https://github.com/ScottPlot/ScottPlot) Богатый функционал, отличная производительность, есть неплохое руководство.

> All charts have MIT license

### Vendors

 * [TeeChart](https://www.componentsource.com/product/teechart-net-for-avalonia) ~360$

## Comparison

### Cartesian Chart

Views        | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | TeeChart
:----------- | :---------: | :---------: | :-----: | :-------: | :------
Line         |      +      |      -      |    +    |     +     |
Bars         |      +      |      -      |    +    |     +     |
Stacked Area |      +      |      -      |    +    |     -     |
Range Area   |      -      |      -      |    +    |     +     |

Diagram             | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | TeeChart
:------------------ | :---------: | :---------: | :-----: | :-------: | :------
Secondary Axes      |      +      |      -      |    +    |     +     |
Logariphmic scale   |      +      |      -      |    +    |     +     |
Zoom/Scroll by axis |      -      |      -      |    +    |     +     |
Constant Lines      |      -      |      -      |    +    |     +     |
Empty Points        |      +      |      -      |    +    |     +     |
ToolTips            |      +      |      -      |    +    |     +     |
Crosshair           |      -      |      -      |    +    |     +     |

### Polar Chart

Features             | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | TeeChart
:------------------- | :---------: | :---------: | :-----: | :-------: | :------
Scatter Line         |      -      |      -      |    +    |     +/-   |
Scrolling/Zooming    |      -      |      -      |    -    |     +/-   |
ToolTips             |      +      |      -      |    -    |     +/-   |
Crosshair            |      -      |      -      |    +    |     +/-   |
Rectangle Viewport   |      -      |      -      |    +    |     +/-   |

ScotPlot - Можно показывать полярные данные на XY, есть специальный хелпер (в 4 версии, в 5 - нету)

### Smith Chart

Exists              | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | TeeChart
:------------------ | :---------: | :---------: | :-----: | :-------: | :------
Smith Chart         |      -      |      -      |    -    |     -     |    +

# Performance

Features                       | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | TeeChart
:----------------------------- | :---------: | :---------: | :-----: | :-------: | :------
4 cartesian lines - 100K each  | Not Usable  |     -       | Bad     | Excellent |
100 cartesian lines - 1K each  | Not Usable  |     -       | Normal  | Normal    |
100 polar lines - 1K each      | Not Usable  |     -       | Good    | Normal    |
