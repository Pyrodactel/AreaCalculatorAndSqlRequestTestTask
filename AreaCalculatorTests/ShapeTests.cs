using AreaCalculator;
using NUnit.Framework;

namespace AreaCalculatorTests;

/// <summary>
/// Тесты фигуры.
/// </summary>
public class ShapeTests
{
	/// <summary>
	/// Вроде как показывает, что площадь можно получить без знания типа фигуры.
	/// </summary>
	/// <param name="radius">Радиус.</param>
	/// <param name="expected">Ожидаемый результат.</param>
	[TestCase(5, Math.PI * 5 * 5)]
	public void GetArea_AnyShape_EqualsExpected(double radius, double expected)
	{
		var circle = new Circle(radius);

		var circleArea = circle.GetArea();
		var shapeAreal = Shape.GetArea(circle);

		Assert.Multiple(() =>
		{
			Assert.That(circleArea, Is.EqualTo(expected));
			Assert.That(shapeAreal, Is.EqualTo(expected));
		});
	}
}