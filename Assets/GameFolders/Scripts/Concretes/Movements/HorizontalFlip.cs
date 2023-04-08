using GameFolders.Scripts.Abstracts.Movements;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Movements
{
    public class HorizontalFlip : IFlip
    {
        private SpriteRenderer _spriteRenderer;

        public HorizontalFlip(SpriteRenderer spriteRenderer)
        {
            _spriteRenderer = spriteRenderer.GetComponent<SpriteRenderer>();
        }
        
        public void FlipCharacter(float direction)
        {
            if (direction == 0f) return;

            if (direction > 0f)
            {
                _spriteRenderer.flipX = true;
            }
            else
            {
                _spriteRenderer.flipX = false;
            }
        }
    } 
}

