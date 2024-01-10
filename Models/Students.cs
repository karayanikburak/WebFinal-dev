using System.ComponentModel.DataAnnotations.Schema;

namespace WebFinal.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //SINIF
        public string Grade { get; set; }

        //ODEVLER
        //ÖĞRENCİ EKLERKEN BAŞLANGIÇTA ÖDEV OLMAYACAGI DUSUNULEREK NULLABLE YAPILDI
        public string? Assignments {  get; set; }




    }
}
