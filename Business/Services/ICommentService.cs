﻿using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface ICommentService
    {
        IResult AddComment(Comment comment);
        IResult DeleteComment(Comment comment);
        IResult UpdateComment(Comment comment);
        IDataResult<List<Comment>> GetListComment();
        IDataResult<Comment> GetComment(int id);
        IDataResult<List<Comment>> GetCommentByBlogID(int id);
        IDataResult<List<Comment>> GetCommentByUserID(int id);
    }
}
