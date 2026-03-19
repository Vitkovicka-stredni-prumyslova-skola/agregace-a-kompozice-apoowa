using System.Runtime.CompilerServices;

namespace AgregaceAKompozice
{
    public class TridniKniha
{
    private readonly Dictionary<Student, List<ZaznamDochazky>> _dochazka;

    public TridniKniha()
    {
        // TODO
        _dochazka = new Dictionary<Student, List<ZaznamDochazky>>();
    }

    public void ZapisDochazku(Student s, DateOnly datum, bool pritomen)
    {
       if(s == null) throw new ArgumentNullException(nameof(s));

       if(!_dochazka.ConstainsKey(s) ||  _dochazka[s].Count == 0)
       {
        Console.WriteLine("žádné záznamy");
        return;
       }
       foreach(var zaznam in _dochazka[s])
       {
        Console.WriteLine(zaznam);
       }
    }

    public void VypisDochazku(Student s)
    {
        // TODO:
        // pokud student nemá záznamy, vypiš "Žádné záznamy"
        // jinak projdi list a vypiš
    }
}
}