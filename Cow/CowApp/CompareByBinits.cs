namespace CowApp;

public class CompareByBinits:IComparer<Cow>
{
    public int Compare(Cow? kuh1, Cow? kuh2)
    {
        
        if (ReferenceEquals(kuh1, kuh2)) return 0;
        if (kuh1 is null) return -1;
        if (kuh2 is null) return 1;
        return kuh1.Binnits.CompareTo(kuh2.Binnits);
    }
}