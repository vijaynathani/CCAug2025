namespace demoR;

internal abstract class Movie
{
    private readonly string _title;

    public Movie(string title)
    {
        _title = title;
    }

    public string Title
    {
        get { return _title; }
    }
    internal abstract double GetAmount(int daysRented);
    internal virtual int GetFrequentRenterPoitns(int daysRented) => 1;
}
class RegularMovie : Movie
{
    public RegularMovie(string title) : base(title)
    {
    }

    internal override double GetAmount(int daysRented)
    {
        double r = 2;
        if (daysRented > 2)
            r += (daysRented - 2) * 1.5;
        return r;
    }
}
class ChildrenMovie : Movie
{
    public ChildrenMovie(string title) : base(title)
    {
    }
    internal override double GetAmount(int daysRented)
    {
        double r = 1.5;
        if (daysRented > 3)
            r += (daysRented - 3) * 1.5;
        return r;
    }

}
class NewReleaseMovie : Movie
{
    public NewReleaseMovie(string title) : base(title)
    {
    }
    internal override double GetAmount(int daysRented)
    {
        return daysRented * 3;
    }
    internal override int GetFrequentRenterPoitns(int daysRented)
    {
        var r = base.GetFrequentRenterPoitns(daysRented);
        if (daysRented > 1) r++;
        return r;
    }
}