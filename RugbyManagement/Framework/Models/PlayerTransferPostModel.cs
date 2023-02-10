using RugbyManagement.Framework.ViewModels;

namespace RugbyManagement.Framework.Models
{
    public class PlayerTransferPostModel
    {
        public int PlayerId { get; set; }
        public int ToTeamId { get; set; }
        public DateTime TransferDate { get; set; }
    }
}
