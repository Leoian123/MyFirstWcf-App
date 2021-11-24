using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialator
{
    public class SerialatorOnDb 
    {
        public Contatto GetContattoFromDb(int id) 
        {
            using (wcfEntities1 ctx = new wcfEntities1()) 
            {
                var contatto = ctx.contatto.FirstOrDefault(x => x.id==id);
                if (contatto != null) 
                {
                    return new Contatto()
                    {
                        Id = contatto.id,
                        Nome = contatto.nome,
                        Cognome = contatto.cognome,
                        NumberPhone = contatto.numberPhone,
                        BirthDay = contatto.birthday
                    };
                }
            }
            return null;
        }

        public List<Contatto> GetAllContatti() 
        {
            using (wcfEntities1 ctx = new wcfEntities1()) 
            {
                List<Contatto> rubrica = new List<Contatto>();
                List<contatto> rubricaDb = ctx.contatto.ToList();
                foreach (contatto c in rubricaDb)
                {
                    rubrica.Add(new Contatto()
                    {
                        Id = c.id,
                        Nome = c.nome,
                        Cognome = c.cognome,
                        NumberPhone = c.numberPhone,
                        BirthDay = c.birthday
                    }) ;
                }
                return rubrica;
            }
        }

        public int Subscribe(Contatto subscriber) 
        {
            using (wcfEntities1 ctx = new wcfEntities1()) 
            {
                contatto flagSubscriber = new contatto()
                {
                    nome = subscriber.Nome,
                    cognome = subscriber.Cognome,
                    numberPhone = subscriber.NumberPhone,
                    birthday = subscriber.BirthDay
                };
                ctx.contatto.Add(flagSubscriber);
                ctx.SaveChanges();
                return flagSubscriber.id;
            }
        }

        public bool Update(Contatto model) 
        {
            using (wcfEntities1 ctx = new wcfEntities1()) 
            {
                contatto output = ctx.contatto.SingleOrDefault(c=>c.id==model.Id);
                if (output != null) 
                {
                    output.nome = model.Nome;
                    output.cognome = model.Cognome;
                    output.numberPhone = model.NumberPhone;
                    output.birthday = model.BirthDay;
                    ctx.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
