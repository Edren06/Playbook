using RugbyManagement.Framework.ViewModels;

namespace RugbyManagement.Framework.Models
{
    public class PlayerPostModel
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Decimal? HeightInCm { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string TeamName { get; set; }
    }
}
