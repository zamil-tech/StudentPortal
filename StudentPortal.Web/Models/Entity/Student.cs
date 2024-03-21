using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Web.Models.Entity
{
    // this is our domain model
    public class Students
    {
        [Key]
        public  int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Subscribed { get; set; }

        internal static object ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
