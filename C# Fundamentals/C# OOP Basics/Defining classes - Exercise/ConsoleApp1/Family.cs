
using System.Collections.Generic;
using System.Linq;

class Family
{
    private List<Person> listOfPeople;
    
    public Family()
    {
        listOfPeople = new List<Person>();
    }

    public void AddMember(Person member)
    {
        if (member!=null)
        {
            listOfPeople.Add(member);
        }
    }

    public Person GetOldestMember()
    {
        return listOfPeople.OrderByDescending(x => x.age).ToArray()[0];
    }

    public Person[] OlderThan30()
    {
        return listOfPeople.Where(x => x.age>30).OrderBy(x=>x.name).ToArray();
    }
}
