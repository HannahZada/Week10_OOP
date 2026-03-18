public class Truck : Vehicle
{
    private double payloadTons;

    public double PayloadTons
    {
        get { return payloadTons; }
        set { payloadTons = value; }
    }

    public Truck(string make, string model, int year, double dailyRate, double payloadTons)
        : base(make, model, year, dailyRate)
    {
        PayloadTons = payloadTons;
    }

    public override double CalculateRentalCost(int days)
    {
        double extra = 30 * PayloadTons;
        return (DailyRate + extra) * days;
    }

    public override string GetDescription()
    {
        return $"{Year} {Make} {Model} ({PayloadTons} tons) — RM {DailyRate:F2}/day";
    }
}