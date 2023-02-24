namespace AreaCalculator;

/// <summary>
/// Фигура.
/// </summary>
public static class Shape
{
	/// <summary>
	/// Возвращает круг с заданным радиусом.
	/// </summary>
	/// <param name="radius">Радиус круга.</param>
	/// <returns>Круг с заданным радиусом.</returns>
	public static IShape CreateCircle(double radius)
	{
		return new Circle(radius);
	}

	/// <summary>
	/// Возвращает треугольник с заданным радиусом.
	/// </summary>
	/// <param name="sideA">Сторона A.</param>
	/// <param name="sideB">Сторона B.</param>
	/// <param name="sideC">Сторона C.</param>
	/// <returns>Треугольник с заданным радиусом.</returns>
	public static IShape CreateTriangle(double sideA, double sideB, double sideC)
	{
		return new Triangle(sideA, sideB, sideC);
	}

	/// <summary>
	/// Возвращает площадь фигуры, вроде как, без знания типа фигуры в compile-time.
	/// </summary>
	/// <param name="shape">Фигура.</param>
	/// <returns>Площадь переданной фигуры.</returns>
	/// <exception cref="ArgumentNullException">Неинициализированная фигура.</exception>
	public static double GetArea(IShape shape)
	{
		if (shape == null)
		{
			throw new ArgumentNullException(nameof(shape));
		}

		return shape.GetArea();
	}
}