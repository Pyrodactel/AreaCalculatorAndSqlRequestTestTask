using AreaCalculator;
using NUnit.Framework;

namespace AreaCalculatorTests;

/// <summary>
/// Тесты треугольника.
/// </summary>
public class TriangleTests
{
	/// <summary>
	/// Проверяет создание с неположительными сторонами.
	/// </summary>
	/// <param name="sideA">Сторона A.</param>
	/// <param name="sideB">Сторона B.</param>
	/// <param name="sideC">Сторона C.</param>
	[TestCase(-3, 4, 5)]
	[TestCase(3, -4, 5)]
	[TestCase(3, 4, -5)]
	[TestCase(0, 4, 5)]
	public void Initializing_NonPositiveSides_ThrowsArgumentException(double sideA, double sideB, double sideC)
	{
		Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
	}

	/// <summary>
	/// Проверяет создание несуществующего треугольника.
	/// </summary>
	/// <param name="sideA">Сторона A.</param>
	/// <param name="sideB">Сторона B.</param>
	/// <param name="sideC">Сторона C.</param>
	[TestCase(1, 4, 5)]
	[TestCase(2, 2, 5)]
	[TestCase(3, 4, 1)]
	public void Initializing_NotExistedTriangle_ThrowsArgumentException(double sideA, double sideB, double sideC)
	{
		Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
	}

	/// <summary>
	/// Проверяет метод GetArea с существующими треугольниками.
	/// </summary>
	/// <param name="sideA">Сторона A.</param>
	/// <param name="sideB">Сторона B.</param>
	/// <param name="sideC">Сторона C.</param>
	/// <param name="expected">Ожидаемое значение.</param>
	[TestCase(3, 4, 5, 6)]
	[TestCase(5, 12, 13, 30)]
	public void GetArea_PositiveSides_EqualsExpected(double sideA, double sideB, double sideC,
		double expected)
	{
		var triangle = new Triangle(sideA, sideB, sideC);

		var triangleArea = triangle.GetArea();

		Assert.That(triangleArea, Is.EqualTo(expected));
	}

	/// <summary>
	/// Проверяет метод IsRightAngled с существующими правильными и неправильными треугольниками.
	/// </summary>
	/// <param name="sideA">Сторона A.</param>
	/// <param name="sideB">Сторона B.</param>
	/// <param name="sideC">Сторона C.</param>
	/// <param name="expected">Ожидаемое значение.</param>
	[TestCase(3, 4, 5, true)]
	[TestCase(5, 12, 13, true)]
	[TestCase(5, 12, 14, false)]
	public void IsRightAngled_PositiveSides_EqualsExpected(double sideA, double sideB, double sideC,
		bool expected)
	{
		var triangle = new Triangle(sideA, sideB, sideC);

		var isRightAngled = triangle.IsRightAngled();

		Assert.That(isRightAngled, Is.EqualTo(expected));
	}
}