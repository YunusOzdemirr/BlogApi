﻿using System;
using System.Threading.Tasks;
using CmnSoftwareBackend.Entities.ComplexTypes;
using CmnSoftwareBackend.Entities.Dtos.CommentWithUserDtos;
using CmnSoftwareBackend.Shared.Utilities.Results.Abstract;

namespace CmnSoftwareBackend.Services.Abstract
{
    public interface ICommentWithUserService
    {
        Task<IDataResult> GetAllAsync(bool? isActive, bool? isDeleted, bool isAscending, int currentPage, int pageSize, OrderBy orderBy);
        Task<IDataResult> GetByIdAsync(int commentWithUserId);
        Task<IDataResult> AddAsync(CommentWithUserAddDto commentWithUserAddDto);
        Task<IDataResult> UpdateAsync(CommentWithUserUpdateDto commentWithUserUpdateDto);
        Task<IDataResult> DeleteAsync(int commentWithUserId);
        Task<IResult> HardDeleteAsync(int commentWithUserId);
    }
}
