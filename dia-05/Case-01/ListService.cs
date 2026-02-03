using System.Buffers;
using DataVisitant;
using GenerateId;
namespace Service
{
    public class ListService
    {
        GenerateID generateID = new GenerateID();
        public List<Visitantes> Visitantes {get; private set;}= new List<Visitantes>();

        public void AddUser(string name, string docs, DateTime Data) 
        {
            
            Visitantes.Add(new Visitantes(name, docs,Data, true,  generateID.getNewID()));
        }

        public void ExitVisit(string name)
        {
            foreach (var visit in Visitantes)
            {
                if(visit.Name.ToUpper() == name)
                {
                    visit.isHosped = false;
                }
            }            
        }
    }
}