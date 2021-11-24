using Serialator;
using Serialator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per Class1
/// </summary>
public class ServiceOnDb : IService
{
    public List<Contatto> GetAllContatti()
    {
        SerialatorOnDb serDb = new SerialatorOnDb();
        return serDb.GetAllContatti();
    }

    public Contatto GetContatto(int id)
    {
        SerialatorOnDb serDb = new SerialatorOnDb();
        return serDb.GetContattoFromDb(id);
    }

    public void InsertXml(Person xml)
    {
        throw new NotImplementedException();
    }

    public int Subscribe(Contatto input)
    {
        SerialatorOnDb serDb = new SerialatorOnDb();
        return serDb.Subscribe(input);
    }

    public bool UpdateContatto(Contatto model)
    {
        SerialatorOnDb serDb = new SerialatorOnDb();
        return serDb.Update(model);
    }
}