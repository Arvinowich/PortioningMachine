using PortioningMachine.SystemComponents;

namespace PortioningMachine;

public class controlUnit
{
    public void WhereToPutItem(Item i1)
    {
        if (i1.Weight < 2000)
        {
            Console.WriteLine("Putting it in bin 1");
        }
    }


}