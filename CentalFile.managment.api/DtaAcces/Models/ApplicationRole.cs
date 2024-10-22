using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

using Microsoft.AspNetCore.Identity;

namespace CentalFile.managment.api.DtaAcces.Models
{
    public class ApplicationRole : IdentityRole<UserId> { }
    public class UserClaim : IdentityUserClaim<UserId> { }
    public class UserRole : IdentityUserRole<UserId> { }
    public class UserLogin : IdentityUserLogin<UserId> { }
    public class UserToken : IdentityUserToken<UserId> { }
    public class RoleClaim : IdentityRoleClaim<UserId> { }

}
