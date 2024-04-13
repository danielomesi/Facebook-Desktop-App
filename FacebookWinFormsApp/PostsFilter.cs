using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

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
}
