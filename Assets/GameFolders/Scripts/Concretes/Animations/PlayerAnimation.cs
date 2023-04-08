using GameFolders.Scripts.Abstracts.Animations;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Animations
{
    public class PlayerAnimation : IAnimation
    {
        private Animator _animator;

        public PlayerAnimation(Animator animator)
        {
            _animator = animator;
        }
        
        public void HorizontalWalkAnimation(float horizontal)
        {
            _animator.SetFloat("horizontalSpeed", Mathf.Abs(horizontal));
        }

        public void VerticalWalkAnimation(float vertical, bool upSide, bool downSide)
        {
            switch (vertical)
            {
                case >0:
                    upSide = true;
                    downSide = false;
                    _animator.SetBool("upSide", upSide);
                    break;
                case <0:
                    upSide = false;
                    downSide = true;
                    _animator.SetBool("downSide", downSide);
                    break;
                case 0:
                    upSide = false;
                    downSide = false;
                    _animator.SetBool("upSide", upSide);
                    _animator.SetBool("downSide", downSide);
                    break;
            }
        }
    }

}
