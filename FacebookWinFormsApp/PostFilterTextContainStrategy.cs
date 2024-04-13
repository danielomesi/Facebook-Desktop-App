using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostFilterTextContainStrategy : IPostFilteringStrategy
    {
        public bool ShouldInclude(Post i_Post, object i_OptinalParam)
        {
            bool shouldInclude = false;

            if (!string.IsNullOrEmpty(i_Post.Message) && i_OptinalParam is string str)
            {
                shouldInclude = i_Post.Message.ToLower().Contains(str);
            }

            return shouldInclude;
        }
    }
}