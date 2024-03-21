using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostFilterTypeStrategy : IPostFilteringStrategy
    {
        public bool ShouldInclude(Post i_Post, object i_OptinalParam)
        {
            bool shouldInclude = false;

            if (i_OptinalParam is Post.eType comparedType)
            {
                shouldInclude = (i_Post.Type == comparedType);
            }

            return shouldInclude;
        }
    }
}