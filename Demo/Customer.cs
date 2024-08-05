using System.Collections.Generic;
using System.Text;

namespace demoR;

internal class Customer
{
    private readonly string _name;
    private readonly List<Rental> _rentals = new List<Rental>();

    public Customer(string name)
    {
        _name = name;
    }

    public void AddRental(Rental arg)
    {
        _rentals.Add(arg);
    }

    public string GetName()
    {
        return _name;
    }
    public const string TAB="\t", NEW_LINE="\n";
    private double TotalAmount() => _rentals.Sum(r => r.GetAmount());
    private int TotalPoints() => _rentals.Sum(r=>r.GetFrequentRenterPoints());
    private String PrintRental(Rental r) => TAB + r.Movie.Title + TAB + r.GetAmount();
    public string Statement()
    {
        return new StringBuilder("Rental Record for " + GetName() + NEW_LINE)
            .Append(String.Join(NEW_LINE, _rentals.Select(PrintRental)))
             .Append("Amount owed is " + TotalAmount() + NEW_LINE)
             .Append("You earned " + TotalPoints() + " frequent renter points")
              .ToString();
    }
}