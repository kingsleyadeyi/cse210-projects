public class Fraction
{
    private int _top;
    private int _bottom;

    // No-argument constructor
    // Initializes the fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // One-parameter constructor
    // Initializes the fraction to top/1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Two-parameter constructor
    // Initializes the fraction to top/bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the top number
    public int GetTop()
    {
        return _top;
    }

    // Setter for the top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the bottom number
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}