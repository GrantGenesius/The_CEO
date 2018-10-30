using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Staff_Menu : MonoBehaviour {
    public int staff_isclicked = 1;
    public int colliding = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Staff")
                {
                    staff_isclicked = 0;
                    colliding = 0;
                }
                else
                {
                    staff_isclicked = 1;
                }
            }
        }
	}



    void OnCollisionStay(Collision coll) { 
        if (coll.gameObject.name == "CEO" && staff_isclicked == 0)
        {
            while (colliding == 0)
            {
                Debug.Log("display staff menu now!");
                colliding = 1;
            }
        }
        Show_Staff_Menu();
    }



    void Show_Staff_Menu() { 
    
    
    
    }
}
