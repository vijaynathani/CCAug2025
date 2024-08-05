namespace demoR;

internal class Rental
{
    private readonly int _daysRented;
    private readonly Movie _movie;

    public Rental(Movie movie, int daysRented)
    {
        _movie = movie;
        _daysRented = daysRented;
    }

    public Movie Movie
    {
        get { return _movie; }
    }

    public int DaysRented
    {
        get { return _daysRented; }
    }
    public double GetAmount() => _movie.GetAmount(_daysRented);
    public int GetFrequentRenterPoints() => _movie.GetFrequentRenterPoitns(_daysRented);
}