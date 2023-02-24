namespace AreaCalculator;

/// <summary>
/// Интерфейс фигуры.
/// </summary>
public interface IShape
{
	/// <summary>
	/// Возвращает площадь фигуры.
	/// </summary>
	/// <returns>Площадь фигуры.</returns>
	public double GetArea();
}