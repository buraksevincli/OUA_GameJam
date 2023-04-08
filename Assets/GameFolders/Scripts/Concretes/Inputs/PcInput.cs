using GameFolders.Scripts.Abstracts.Inputs;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Inputs
{
    public class PcInput : IPlayerInput
    {
        public float Horizontal => Input.GetAxis("Horizontal");
        public float Vertical => Input.GetAxis("Vertical");
    }
}

