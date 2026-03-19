namespace AgregaceAKompozice
{
public class Trida
{
    public string Nazev { get; }
    public List<Student> Studenti { get; }

    // KOMPOZICE: třídní kniha vzniká spolu s třídou
    public TridniKniha TridniKniha { get; }

  public Trida(string nazev)
    {
        if(string.IsNullOrWhiteSpace(nazev))
            throw new ArgumentNullException("Název třídy nesmí být prázdné.", nameof(nazev));

        Nazev = nazev.Trim();

        TridniKniha = new TridniKniha();
    }

    // AGREGACE: student existuje i bez třídy
   public void PridejStudenta(Student s)
    {   
        if (s == null) throw new ArgumentNullException(nameof(s));
        if (Studenti.Contains(s))
            throw new InvalidEnumArgumentException("Student již je ve třídě zapsán.");
        Studenti.Add(s);
    }

    public void OdeberStudenta(Student s)
    {
        Studenti.Remove(s);
         if (!Studenti.Contains(s))
            throw new InvalidEnumArgumentException("Student není ve třídě zapsán.");
       
        Studenti.Remove(s);
    }

  public void VypisStudenty()
    {
        Console.WriteLine($"Třída: (Nazev)");

        if (Student.count == 0)
        {
            console.writeline("Žádní studenti nejsou zapsání")
        }
        for (int 1=0; int < Studenti.Count; i++)
        {
            Console.WriteLine($"(i+1). {Studenti[i]}");
        }
    }
}
}