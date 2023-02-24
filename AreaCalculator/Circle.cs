namespace AreaCalculator;

/// <summary>
/// Круг.
/// </summary>
public class Circle : IShape
{
	/// <summary>
	/// Радиус.
	/// </summary>
	private readonly double _radius;

	/// <summary>
	/// Конструктор.
	/// </summary>
	/// <param name="radius">Радиус.</param>
	/// <exception cref="ArgumentOutOfRangeException">Неверный аргумент.</exception>
	public Circle(double radius)
	{
		if (radius < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(radius), "Радиус круга не может быть меньше 0.");
		}

		_radius = radius;
	}

	/// <summary>
	/// Возвращает площадь.
	/// </summary>
	/// <returns>Площадь круга.</returns>
	public double GetArea()
	{
		return Math.PI * Math.Pow(_radius, 2);
	}
}