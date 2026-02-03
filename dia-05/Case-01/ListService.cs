using System.Buffers;
using System.Dynamic;
using System.Globalization;
using DataVisitant;
using GenerateId;
using System.Linq;
namespace Service
{
    public class ListService
    {
        GenerateID generateID = new GenerateID();
        public List<Visitantes> VisitantesList {get; private set;}= new List<Visitantes>();

        public void AddUser(string name, string docs) 
        {
            
            VisitantesList.Add(new Visitantes(name, docs,DateTime.Now, true,  generateID.getNewID()));
        }

        public void ExitVisit(string name)
        {
            foreach (var visit in VisitantesList)
            {
                if(visit.Name.ToUpper() == name)
                {
                    visit.isHosped = false;
                }
            }            
        }
        
        public List<Visitantes> GetListOrdById()
        {
            return VisitantesList.OrderBy(p => p.ID).ToList();

        }
        
    }
}