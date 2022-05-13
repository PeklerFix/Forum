using Forum.Core.Repositories.BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Core.Services;
using Forum.Domain;
using Forum.Core.Services.Models.AppUserModels;

namespace Forum.Core.Interfaces.AppUserService
{
    public interface IAppUserService : IService<FormModelAppUser>
    {
    }
}
