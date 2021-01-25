using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExperimentTool
{
    public class MainView : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKey(KeyCode.W))
            {
                this.gameObject.transform.position+=this.gameObject.transform.forward*5*Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                this.gameObject.transform.position-=this.gameObject.transform.forward*5*Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.position+=this.gameObject.transform.right*5*Time.deltaTime;
            }
            else if(Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.position-=this.gameObject.transform.right*5*Time.deltaTime;
            }
            else if(Input.GetKey(KeyCode.U))
            {
                this.gameObject.transform.position+=this.gameObject.transform.up*5*Time.deltaTime;
            }
            else if(Input.GetKey(KeyCode.J))
            {
                this.gameObject.transform.position-=this.gameObject.transform.up*5*Time.deltaTime;
            }
            else if(Input.GetKey(KeyCode.Z))
            {
                
            }
            else if(Input.GetKey(KeyCode.X))
            {
                this.gameObject.transform.position
            }
        }

        public void OnGUI() 
        {
            
        }
    }
}