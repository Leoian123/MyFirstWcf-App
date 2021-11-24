using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Serialator;
using Serialator.Entities;

// NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService" nel codice e nel file di configurazione contemporaneamente.
[ServiceContract]
public interface IService
{

	[OperationContract]
	Contatto GetContatto(int id);

	[OperationContract]
	List<Contatto> GetAllContatti();
	
	[OperationContract]
	int Subscribe(Contatto input);
	[OperationContract]
	void InsertXml(Person xml);
    [OperationContract]
    bool UpdateContatto(Contatto model);

    // TODO: aggiungere qui le operazioni del servizio
}

// Per aggiungere tipi compositi alle operazioni del servizio utilizzare un contratto di dati come descritto nell'esempio seguente.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
