# Avalonia-Charts-Comparison
Comparison of open source charts for Avalonia.

## Chart Controls

### OpenSource

* [LiveCharts2](https://github.com/beto-rodriguez/LiveCharts2)
* [Microcharts](https://github.com/AvaloniaCommunity/Avalonia.Microcharts)
* [OxyPlot](https://github.com/oxyplot/oxyplot-avalonia)
* [ScottPlot](https://github.com/ScottPlot/ScottPlot)

> All charts have MIT license

### Vendors

 * [TeeChart](https://www.steema.com/product/net_avalonia) [Samples](https://github.com/Steema/TeeChart-Avalonia-Samples) 379$

## Comparison

### Cartesian Chart

Views        | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | TeeChart
:----------- | :---------: | :---------: | :-----: | :-------: | :------
Line         |      +      |      -      |    +    |     +     |    +
Bars         |      +      |      -      |    +    |     +     |    +
Stacked Area |      +      |      -      |    +    |     -     |    -
Range Area   |      -      |      -      |    +    |     +     |    -

Diagram             | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | TeeChart
:------------------ | :---------: | :---------: | :-----: | :-------: | :------
Secondary Axes      |      +      |      -      |    +    |     +     |    +/-
Logariphmic scale   |      +      |      -      |    +    |     +     |    -
Zoom/Scroll by axis |      -      |      -      |    +    |     +     |    -
Constant Lines      |      -      |      -      |    +    |     +     |    -
Empty Points        |      +      |      -      |    +    |     +     |    -
ToolTips            |      +      |      -      |    +    |     +     |    -
Crosshair           |      -      |      -      |    +    |     +     |    -

 > **TeeChart** - только по одной вторичной оси

### Polar Chart

Features             | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | TeeChart
:------------------- | :---------: | :---------: | :-----: | :-------: | :------
Scatter Line         |      -      |      -      |    +    |     -     |    -
Scrolling/Zooming    |      -      |      -      |    -    |     -     |    -
ToolTips             |      +      |      -      |    -    |     -     |    -
Crosshair            |      -      |      -      |    +    |     -     |    -
Rectangle Viewport   |      -      |      -      |    +    |     -     |    -

 > **ScotPlot** - Можно показывать полярные данные на XY, есть специальный хелпер (в 4 версии, в 5 - нет)

 > **TeeChart** - на сайте написано что есть, но в пакете для Avalonia нет

### Smith Chart

Exists              | LiveCharts2 | Microcharts | OxyPlot | ScottPlot | TeeChart
:------------------ | :---------: | :---------: | :-----: | :-------: | :------
Smith Chart         |      -      |      -      |    -    |     -     |    -

> **TeeChart** - на сайте написано что есть, но в пакете для Avalonia не нашел

# Performance

Features                       | LiveCharts2 | Microcharts | OxyPlot   | ScottPlot | TeeChart
:----------------------------- | :---------: | :---------: | :-------: | :-------: | :------
4 cartesian lines - 100K each  | Not Usable  |     -       | Very Slow | Very Fast | Not Usable
100 cartesian lines - 1K each  | Not Usable  |     -       | Slow      | Slow      | Not Usable
100 polar lines - 1K each      | Not Usable  |     -       | Normal    | Slow      | -

# Conclusion

## LiveCharts2

Презентационные чарты, много анимаций, мало фич, не предназначены для работы с большими данными.

## Microcharts

Нет nuget пакета, порт под Avalonia выглядит заброшенным: Net Core 3, Avalonia 10. В целом не работоспособен.

## OxyPlot

Богатый функционал, неплохая производительность для одиночной серии, старомодные. Дока старая, примеров много.

Нет диаграмы Смита.

## ScottPlot

Богатый функционал, лучшая производительность для небольшого количества серий, есть неплохое руководство.

Малое количество видов, нет полярной диаграммы и диаграммы Смита. Активно разрабатывается.

## TeeChart

На сайте написано про богатый функционал, но в пакете для Avalonia только базовые вещи.
 
В целом весьма не удобен, примеры скудные, документация ужасна, производительность тоже.
