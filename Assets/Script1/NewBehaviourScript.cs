using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExperimentTool
{
    public abstract class CircuitLabDesk : MonoBehaviour
    {
        public void OnGUI() 
        {
            
        }
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("HelloWorld");
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                
            }
        }
    }
}