using System;

namespace AvaloniaChartsComparison.Models;

public class DataGenerator
{
    private const int Amplitude = 10;
    private const int LargeSeriesPointsCount = 100_000;
    private const int SmallSeriesPointsCount = 1_000;
    public const int LargeSeriesCount = 4;
    public const int SmallSeriesCount = 100;

    private readonly Random random = new (0);
    
    public double[][] LargeXYSeriesValues { get; } = new double[LargeSeriesCount][];
    public double[][] SmallXYSeriesValues { get; } = new double[SmallSeriesCount][];
    public double[][] PolarSeriesValues { get; } = new double[SmallSeriesCount][];
    public double[] PolarSeriesArguments { get; } = new double[SmallSeriesPointsCount];

    public DataGenerator()
    {
        for (int i = 0; i < LargeSeriesCount; i++)
            LargeXYSeriesValues[i] = GenerateSinus(LargeSeriesPointsCount);
        
        for (int i = 0; i < SmallSeriesCount; i++)
            SmallXYSeriesValues[i] = GenerateSinus(SmallSeriesPointsCount);
        
        for (int i = 0; i < SmallSeriesCount; i++)
            PolarSeriesValues[i] = GenerateSpiral(SmallSeriesPointsCount, i);
    }

    private double[] GenerateSpiral(int count, double start)
    {
        const double minAngleDegree = 0;
        const double maxAngleDegree = 720;

        double[] result = new double[count];
        double minAngle = FromDegrees(minAngleDegree);
        double maxAngle = FromDegrees(maxAngleDegree);
        double angleStep = (maxAngle - minAngle) / count;
        for (int i = 0; i < count; i++)
        {
            double angle = start + i * angleStep;
            double angleRadians = ToRadian(angle);
            PolarSeriesArguments[i] = angleRadians + random.NextDouble() - 0.5;
            double normalAngle = NormalizeAngle(angle);
            result[i] = normalAngle;
        }

        return result;

        double NormalizeAngle(double angle) => angle % 360;
        double ToRadian(double angle) => angle * Math.PI / 180.0;
        double FromDegrees(double angle) => angle;
    }

    private double[] GenerateSinus(int count)
    {
        double[] result = new double[count];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = (Math.Sin(i) + 0.25 * random.NextDouble()) * Amplitude;
        }
        return result;
    }
}