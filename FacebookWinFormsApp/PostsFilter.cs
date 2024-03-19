using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class PostsFilter
    {
        public IPostFilteringStrategy m_PostFilterStrategy;

        public PostsFilter(IPostFilteringStrategy i_PostFilterStrategy)
        {
            m_PostFilterStrategy = i_PostFilterStrategy;
        }

        public List<Post> Filter(List<Post> i_Posts, object i_OptionalParam)
        {
            List<Post> filteredList = new List<Post>();

            foreach (Post post in i_Posts)
            {
                if (m_PostFilterStrategy.ShouldInclude(post, i_OptionalParam))
                {
                    filteredList.Add(post);
                }
            }

            return filteredList;
        }
    }

    public interface IPostFilteringStrategy
    {
        bool ShouldInclude(Post i_Post, object i_OptinalParam);
    }

    public class PostFilterTypeStrategy : IPostFilteringStrategy
    {
        public bool ShouldInclude(Post i_Post, object i_OptinalParam)
        {
            if (i_OptinalParam is Post.eType comparedType)
            {
                return i_Post.Type == comparedType;
            }
            return false;
        }
    }

    public class PostFilterTextContainStrategy : IPostFilteringStrategy
    {
        public bool ShouldInclude(Post i_Post, object i_OptinalParam)
        {
            if (!string.IsNullOrEmpty(i_Post.Message) && i_OptinalParam is string str)
            {
                return i_Post.Message.ToLower().Contains(str);
            }
            return false;
        }
    }
}
