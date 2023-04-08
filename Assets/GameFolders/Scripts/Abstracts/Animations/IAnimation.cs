namespace GameFolders.Scripts.Abstracts.Animations
{
    public interface IAnimation
    {
        void HorizontalWalkAnimation(float horizontal);
        void UpSideWalkAnimation(bool upSide);
        void DownSideWalkAnimation(bool downSide);
        void VerticalWalkAnimation(float vertical, bool upSide, bool downSide);
    }
}

