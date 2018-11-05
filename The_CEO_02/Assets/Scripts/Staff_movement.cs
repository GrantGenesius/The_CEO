using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class Staff_movement : MonoBehaviour {
    public NavMeshAgent agent;
    public Rigidbody Prefab;
    public Transform locateStaffToTrain;
    public Transform locateStaffToWork;
    public Transform locateStaffToMarket;
    public GameObject selectedStaff;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;

            //if (Physics.Raycast(ray, out hit))
            //{
                //agent.SetDestination(hit.point);
                //if (!EventSystem.current.IsPointerOverGameObject())
                //    agent.destination = hit.point;
            //}


        }
	}

    public void TrainStaff() {
        
        agent.destination = locateStaffToTrain.position;
    }

    public void MarketStaff() {
        agent.destination = locateStaffToMarket.position;
    }

    public void WorkStaff() {
        agent.destination = locateStaffToWork.position;
    }
}
