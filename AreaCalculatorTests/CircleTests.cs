using AreaCalculator;
using NUnit.Framework;

namespace AreaCalculatorTests;

/// <summary>
/// Тесты круга.
/// </summary>
public class CircleTests
{
	/// <summary>
	/// Проверяет создание с отрицательным радиусом.
	/// </summary>
	/// <param name="radius">Радиус.</param>
	[TestCase(-1)]
	public void Initializing_NegativeRadius_ThrowsArgumentOutOfRangeException(double radius)
	{
		Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
	}

	/// <summary>
	/// Проверяет метод GetArea с неотрицательным радиусом.
	/// </summary>
	/// <param name="radius">Радиус.</param>
	/// <param name="expected">Ожидаемое значение.</param>
	[TestCase(0, Math.PI * 0 * 0)]
	[TestCase(5, Math.PI * 5 * 5)]
	public void GetArea_NonNegativeRadius_EqualsExpected(double radius, double expected)
	{
		var circle = new Circle(radius);

		var circleArea = circle.GetArea();

		Assert.That(circleArea, Is.EqualTo(expected));
	}
}