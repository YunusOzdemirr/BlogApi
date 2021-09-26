﻿using System;
using CmnSoftwareBackend.Entities.Concrete;

namespace CmnSoftwareBackend.Entities.Dtos.CommentWithoutUserDtos
{
    public class CommentWithoutUserDto
    {
        public string UserName { get; set; }
        public string Text { get; set; }
        public sbyte Star { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedByUserName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedByUserName { get; set; }
    }
}
