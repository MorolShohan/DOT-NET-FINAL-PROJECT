using System.Collections.Generic;

namespace BLL.DTOs
{
    public class PostCommentDto : StudentPostDTO
    {

        public PostCommentDto()
        {
            StudentPosts = new List<StudentCommentDTO>();
        }
        public List<StudentCommentDTO> StudentPosts { get; set; }
    }
}
