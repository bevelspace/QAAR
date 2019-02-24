using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bevel;

namespace Bevel
{
    public class MarkUpManager : MonoBehaviour
    {

        private BevelInput bevelInput;

        // Use this for initialization
        void Start()
        {
            bevelInput = FindObjectOfType<BevelInput>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        //Just to initialize the process. Turn on that listeners for that. 
        public void StartMarkup()
        {
            bevelInput.clickHitEvent += AddMarkUp;
        }

        //for adding new markup by spatial interface
        public void AddMarkUp(RaycastHit hit)
        {

        }

        //for loading markups that are saved to the server
        public void LoadMarkup()
        {

        }

    }

    public class MarkUp
    {

    }

}
