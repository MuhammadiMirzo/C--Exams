public class Calculator
{
    int _first;
    int _second;
    public Calculator(int first,int second)
    {
        _first = first;
        _second = second;
    }

    public int Sum()
    {
        return _first+_second;
    }
    public int Subtract()
    {
        return _first-_second;
    }
    public int Multiplication()
    {
        return _first*_second;
    }
    public int Division()
    {
        return _first/_second;
    }

}