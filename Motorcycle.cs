public class Motorcycle : Vehicle
{
    private bool hasSidecar;

    public bool HasSidecar
    {
        get { return hasSidecar; }
        set { hasSidecar = value; }
    }

    public Motorcycle(string make, string model, int year, double dailyRate, bool hasSidecar)
        : base(make, model, year, dailyRate)
    {
        HasSidecar = hasSidecar;
    }

    public override double CalculateRentalCost(int days)
    {
        double cost = DailyRate * days;

        if (!HasSidecar)
            cost *= 0.9;

        return cost;
    }

    public override string GetDescription()
    {
        string text = HasSidecar ? "with sidecar" : "no sidecar";
        return $"{Year} {Make} {Model} ({text}) — RM {DailyRate:F2}/day";
    }
}