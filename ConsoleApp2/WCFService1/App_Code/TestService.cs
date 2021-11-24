using System;
using Serialator;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Serialator.Entities;

// NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service" nel codice, nel file svc e nel file di configurazione contemporaneamente.
public class TestService : IService
{
	private const string XMLFILE= @"C:\Users\Orazio\source\Serialator\xml.xml";
	private const string FILE = @"C:\Users\Orazio\source\Serialator\Obj.txt";

    public List<Contatto> GetAllContatti()
    {
        return new List<Contatto>();
    }

    public Contatto GetContatto(int id)
	{
		Serialator<Contatto> contatto = new Serialator<Contatto>();
		Contatto output=contatto.Deserialize(System.IO.File.ReadAllText(FILE));
		return output;
	}
    //public string Subscribe(Contatto input) 
    //{
    //	Serialator<Contatto> contatto = new Serialator<Contatto>();
    //	return contatto.Serialize(input, FILE);
    //}
    public void InsertXml(Person xml) 
	{
		Serialator<Person> xmlPerson = new Serialator<Person>();
		xmlPerson.xmlSerialize(xml, XMLFILE);
	}

    public int Subscribe(Contatto input)
    {
        throw new NotImplementedException();
    }

    public bool UpdateContatto(Contatto model)
    {
        throw new NotImplementedException();
    }
}
