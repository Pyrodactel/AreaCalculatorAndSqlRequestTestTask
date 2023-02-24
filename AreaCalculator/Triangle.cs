namespace AreaCalculator;

/// <summary>
/// Треугольник.
/// </summary>
public class Triangle : IShape
{
	/// <summary>
	/// Стороны треугольника.
	/// </summary>
	private readonly double _sideA, _sideB, _sideC;

	/// <summary>
	/// Конструктор.
	/// </summary>
	/// <param name="sideA">Сторона A.</param>
	/// <param name="sideB">Сторона B.</param>
	/// <param name="sideC">Сторона C.</param>
	/// <exception cref="ArgumentException">Неверные аргументы.</exception>
	public Triangle(double sideA, double sideB, double sideC)
	{
		if (sideA <= 0 || sideB <= 0 || sideC <= 0)
		{
			throw new ArgumentException("Сторона треугольника не может быть меньше или равна нулю.");
		}

		if (!IsValidTriangle(sideA, sideB, sideC))
		{
			throw new ArgumentException("Треугольника с такими сторонами не существует.");
		}

		_sideA = sideA;
		_sideB = sideB;
		_sideC = sideC;
	}

	/// <summary>
	/// Возвращает площадь.
	/// </summary>
	/// <returns>Площадь треугольника.</returns>
	public double GetArea()
	{
		var semiperimeter = (_sideA + _sideB + _sideC) / 2;
		return Math.Sqrt(semiperimeter * (semiperimeter - _sideA) * (semiperimeter - _sideB) *
		                 (semiperimeter - _sideC));
	}

	/// <summary>
	/// Показывает является ли треугольник прямоугольным.
	/// </summary>
	/// <returns>true, если треугольник прямоугольный, иначе - false.</returns>
	public bool IsRightAngled()
	{
		var orderedSides = new[] { _sideA, _sideB, _sideC }.OrderDescending().ToArray();
		var differenceBetweenSquares =
			Math.Pow(orderedSides[0], 2) - (Math.Pow(orderedSides[1], 2) + Math.Pow(orderedSides[2], 2));
		return differenceBetweenSquares < Constants.CalculationAccuracy;
	}


	/// <summary>
	/// Показывает является ли треугольник правильным.
	/// </summary>
	/// <param name="a">Сторона a.</param>
	/// <param name="b">Сторона b.</param>
	/// <param name="c">Сторона c.</param>
	/// <returns>true, если треугольник существует, иначе - false.</returns>
	private bool IsValidTriangle(double a, double b, double c)
	{
		return a + b > c && a + c > b && b + c > a;
	}
}