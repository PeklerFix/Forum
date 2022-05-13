using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Domain;
using Forum.Core.Repositories.BaseInterface;

namespace Forum.Core.Interfaces.UserProfile
{
    public interface IUserProfileRepository : IRepository<Forum.Domain.UserProfile>
    {
    }
}
