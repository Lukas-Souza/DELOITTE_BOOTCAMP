namespace DataVisitant
{
    public class Visitantes
    {
        public int ID {get; set;}
        public string Name { get; set; }
        public string Documents { get; set; }
        public DateTime DataVisit { get; set; }
        public bool isVisitPrimary { get; set; }
        public bool isHosped {get; set; }
        
        public Visitantes(string Pname, string Pdocuments, DateTime PdataVisist, bool PisVisitPrimary, int PiD)
        {
            bool isNull = string.IsNullOrWhiteSpace(Pname) && string.IsNullOrWhiteSpace(Pdocuments);
            if (!isNull)
            {

                Name = Pname;
                Documents = Pdocuments;
                DataVisit = PdataVisist;
                isVisitPrimary = PisVisitPrimary;
                isHosped = true;
                ID = PiD;

            }
        } 
    }
}