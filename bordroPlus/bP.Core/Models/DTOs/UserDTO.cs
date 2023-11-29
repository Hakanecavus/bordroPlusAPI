using bP.Core.Models.CoreModels;

namespace bP.Core.Models.DTOs
{
    public class UserDTO
    {
        private long Id { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string email { get; set; }
        private string phone { get; set; }
        private string identityNumber { get; set; }

        private HashSet<Role> role { get; set; }

    }
}
