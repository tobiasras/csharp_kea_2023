namespace Generic_Fellowship;

public class Fellowship<T> 
{
    public Fellowship(List<T> members)
    {
        Members = members;
    }

    public List<T> Members { get; set; }

    
    
    public void AddMember(T member)
    {
        Members.Add(member);
    }

    public void RemoveMember(T member)
    {
        Members.Remove(member);
    }
    
    
    
    
    
    
    
}