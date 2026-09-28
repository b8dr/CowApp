namespace CowApp;

class Program
{
    static void Main(string[] args)
    {
        List<Cow> cows = new List<Cow>();
        string filepath = "file.txt";
        if (!File.Exists((filepath)));
        using (StreamReader sr = new StreamReader(filepath))
        {
            while (!sr.EndOfStream)
            {
               string line = sr.ReadLine();
               if (line.StartsWith('#') || line.StartsWith(';') || line.IsWhiteSpace())
               {
                   continue;
               } 
                string[] parts = line.Split(';');
                cows.Add((new Cow(parts[0], parts[1], int.Parse(parts[2]))));
            

            }
            
        }
        
    }
}