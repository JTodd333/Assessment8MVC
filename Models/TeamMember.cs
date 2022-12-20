using Dapper.Contrib.Extensions;

namespace Assessment8.Models
{
    [Table("TeamMember")]
    public class TeamMember
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string GuestName { get; set; }

    }
}
