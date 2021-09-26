﻿using System;
using System.Collections.Generic;
using CmnSoftwareBackend.Entities.Concrete;

namespace CmnSoftwareBackend.Entities.Dtos.ArticleDtos
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public int CommentCount { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
        public sbyte StarAverage { get; set; }
        public int TotalStarCount { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public ICollection<ArticlePicture> ArticlePictures { get; set; }
        public ICollection<CategoryAndArticle> CategoryAndArticles { get; set; }
        public ICollection<CommentWithUser> CommentWithUsers { get; set; }
        public ICollection<CommentWithoutUser> CommentWithoutUsers { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedByUserName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedByUserName { get; set; }
    }
}