namespace PortioningMachine;

public class arrivalLogger : Ilogger
{
    public double log()
    {
        Console.WriteLine("Item arrived!");
        return 0;
    }
}