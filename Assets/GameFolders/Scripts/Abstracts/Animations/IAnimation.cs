namespace GameFolders.Scripts.Abstracts.Animations
{
    public interface IAnimation
    {
        void HorizontalWalkAnimation(float horizontal);
        void VerticalWalkAnimation(float vertical, bool upSide, bool downSide);
    }
}

