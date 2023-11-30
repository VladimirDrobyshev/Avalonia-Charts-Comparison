# Avalonia-Charts-Comparison
Comparison of open source charts for Avalonia.

## Chart Controls

### OpenSource

* [LiveCharts2](https://github.com/beto-rodriguez/LiveCharts2) - Презентационные чарты, много анимаций, мало фич, не предназначены для работы с большими данными. Blazor-like API. Skia based.
* [Microcharts](https://github.com/AvaloniaCommunity/Avalonia.Microcharts) Нет nuget пакета, порт под Avalonia выглядит заброшенным: Net Core 3, Avalonia 10. В целом не работоспособен.
* [OxyPlot](https://github.com/oxyplot/oxyplot-avalonia) Богатый функционал, хорошая производительность.
* [ScottPlot](https://github.com/ScottPlot/ScottPlot)

> All charts have MIT license

### Vendors

 * [TeeChart](https://www.componentsource.com/product/teechart-net-for-avalonia) ~360$, Есть диаграма Смита.

## Comparison

### Cartesian Chart

Views        | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | Comment
:----------- | :---------: | :---------: | :-----: | :-------: | :------
Line         |      +      |      -      |    +    |           |
Bars         |      +      |      -      |    +    |           |
Stacked Area |      +      |      -      |    +    |           |
Range Area   |      -      |      -      |    +    |           | Можно попробовать заменить с помощью Stacked Area

Diagram             | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | Comment
:------------------ | :---------: | :---------: | :-----: | :-------: | :------
Secondary Axes      |      +      |      -      |    +    |           |
Logariphmic scale   |      +      |      -      |    +    |           |
Zoom/Scroll by axis |      -      |      -      |    +    |           |
Constant Lines      |      -      |      -      |    +    |           | Можно заменить обычной Line серией
Empty Points        |      +      |      -      |    +    |           |
ToolTips            |      +      |      -      |    +    |           |
Crosshair           |      -      |      -      |    +    |           | Тултип на максималках (не нужно точного попадания)

### Polar Chart

Features             | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | Comment
:------------------- | :---------: | :---------: | :-----: | :-------: | :------
Scatter Line         |      -      |      -      |    +    |           |
Scrolling/Zooming    |      -      |      -      |    -    |           |
ToolTips             |      +      |      -      |    -    |           |
Crosshair            |      -      |      -      |    +    |           |
Rectangle Viewport   |      -      |      -      |    +    |           |

### Smith Chart

Exists              | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | Comment
:------------------ | :---------: | :---------: | :-----: | :-------: | :------
Smith Chart         |      -      |      -      |    -    |           |

# Performance

Features                       | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | Comment
:----------------------------- | :---------: | :---------: | :-----: | :-------: | :------
4 cartesian lines - 100K each  | Not Usable  |     -       | Bad     |           |
100 cartesian lines - 1K each  | Not Usable  |     -       | Normal  |           |
100 polar lines - 1K each      | Not Usable  |     -       | Good    |           |
