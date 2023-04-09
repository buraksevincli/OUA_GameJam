using GameFolders.Scripts.Abstracts.Animations;
using GameFolders.Scripts.Abstracts.Inputs;
using GameFolders.Scripts.Abstracts.Movements;
using GameFolders.Scripts.Concretes.Animations;
using GameFolders.Scripts.Concretes.Inputs;
using GameFolders.Scripts.Concretes.Managers;
using GameFolders.Scripts.Concretes.Movements;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float speed;
        
        private IPlayerInput _input;
        private IMover _mover;
        private IAnimation _animation;
        private IFlip _flip;

        private float _horizontal;
        private float _vertical;

        private bool _upSide;
        private bool _downSide;

        private void Awake()
        {
            _input = new PcInput();
            _mover = new Mover(this);
            _flip = new HorizontalFlip(transform.GetChild(0).GetComponent<SpriteRenderer>());
            _animation = new PlayerAnimation(GetComponent<Animator>());
        }

        private void FixedUpdate()
        {
            _mover.Tick(_horizontal, _vertical, speed);
            
            _flip.FlipCharacter(_horizontal);
            
        }

        private void Update()
        {
            if (GameManager.Instance.PlayerAnswer)
            {
                _horizontal = 0f;
                _vertical = 0f;
                return;
            }
            
            _horizontal = _input.Horizontal;
            _vertical = _input.Vertical;

            _animation.VerticalWalkAnimation(_vertical,_upSide,_downSide);
            _animation.HorizontalWalkAnimation(_horizontal);
        }
    }
}

