using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purchasable_lists : MonoBehaviour {

    public List<purchasable_items> item_list = new List<purchasable_items>();

    public static purchasable_lists purchasable_lists;


	// Use this for initialization
	void Start () {
        purchasable_lists = this;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void fill_list() { 
        
    }

}
