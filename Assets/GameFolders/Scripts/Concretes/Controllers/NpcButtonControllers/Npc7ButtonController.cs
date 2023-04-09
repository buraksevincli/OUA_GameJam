using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Abstracts.Controllers;
using TMPro;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class Npc7ButtonController : MonoBehaviour
    {
        [SerializeField] private TMP_Text answer1;
        [SerializeField] private TMP_Text answer2;

        private void OnEnable()
        {
            answer1.text = "FixedUpdate";
            answer2.text = "Update";
        }
    }
}