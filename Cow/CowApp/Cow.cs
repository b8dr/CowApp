namespace CowApp;

public class Cow:IEquatable<Cow>,IComparable<Cow>
{
    public string Name { get;  set; }
    public string Colour { get;  set; }
    public int Age { get;  set; }

    public int Binnits
    {
        get
        {
            return Age / 5 + Colour.Length -3;
        }
    }
    public double Coolness
    {
        get
        {
            return (Age + Name.Length);
        }
        private set;
    }
    public Cow(string name, string colour, int age)
    {
        Name = name;
        Colour = colour;
        Age = age;
    }
    #region Equatable
        public bool Equals(Cow? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Name == other.Name && Colour == other.Colour && Age == other.Age;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Cow)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Colour, Age);
        }
    

    #endregion

    #region compareable
    public int CompareTo(Cow? other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (other is null) return 1;
            var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            var colourComparison = string.Compare(Colour, other.Colour, StringComparison.Ordinal);
            if (colourComparison != 0) return colourComparison;
            return Name.CompareTo(other.Name);
        }
    #endregion

    public override string ToString()
    {
        return $"Name: {Name}, Colour: {Colour}, Age: {Age}, Coolness: {Coolness}, Binnits: {Binnits}";
    }
    
}