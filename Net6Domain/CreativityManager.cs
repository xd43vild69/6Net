using Net6Data;
using Net6DTO;

namespace Net6Domain;
public class CreativityManager
{
    public IList<Soundtrack> GetSoundtrack()
    {
        SoundtrackRepository<Soundtrack> r = new SoundtrackRepository<Soundtrack>();
        var u = r.GetLists();
        return u.ToList();
    }

    public IList<CompositionElements> GetCompositionElements()
    {
        CompositionElementsRepository<CompositionElements> r = new CompositionElementsRepository<CompositionElements>();
        var u = r.GetLists();
        return u.ToList();
    }       
}
