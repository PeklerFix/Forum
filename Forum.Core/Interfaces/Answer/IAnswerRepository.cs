﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Domain;
using DomainAnswer = Forum.Domain.Answer;
using Forum.Core.Repositories.BaseInterface;

namespace Forum.Core.Interfaces.Answer
{
    public interface IAnswerRepository : IRepository<DomainAnswer>
    {
    }

    public interface ITagRepository : IRepository<Tag>
    {
        
    }
}
