using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IPostFilteringStrategy
    {
        bool ShouldInclude(Post i_Post, object i_OptinalParam);
    }
}