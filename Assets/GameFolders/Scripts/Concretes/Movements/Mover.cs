using GameFolders.Scripts.Abstracts.Movements;
using GameFolders.Scripts.Concretes.Controllers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Movements
{
    public class Mover : IMover
    {
        private Rigidbody2D _rigidbody2D;
        
        public Mover(PlayerController playerController)
        {
            _rigidbody2D = playerController.GetComponent<Rigidbody2D>();
        }

        public void Tick(float horizontal, float vertical, float speed)
        {
            Vector2 move = new Vector2(horizontal, vertical);

            _rigidbody2D.velocity = move * speed;
        }
    }
}

