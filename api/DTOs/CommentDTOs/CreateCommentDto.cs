using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.CommentDTOs
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(4, ErrorMessage = "Title must be at least 4 characters")]
        [MaxLength(60, ErrorMessage = "Title cannot be over 60 characters")]
         public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(4, ErrorMessage = "Content must be at least 4 characters")]
        [MaxLength(60, ErrorMessage = "Content cannot be over 600 characters")]
        public string Content { get; set; } =string.Empty;
    }
}