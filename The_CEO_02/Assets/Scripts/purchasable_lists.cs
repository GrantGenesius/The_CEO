using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class purchasable_lists : MonoBehaviour {

    public List<purchasable_items> item_list = new List<purchasable_items>();

    public static purchasable_lists purchasable_list;

    public GameObject item_holder_prefab;

    public Transform grid;

	// Use this for initialization
	void Start () {
        purchasable_list = this;
        fill_list();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void fill_list() {
        for (int i = 0; i < item_list.Count; i++) {
            GameObject holder = Instantiate(item_holder_prefab, grid, false);
            //holder.transform.SetParent(grid);

            Item_Holder holderScript = holder.GetComponent<Item_Holder>();

            holderScript.item_name.text = item_list[i].item_name;
            

            holderScript.item_price.text = "$ " + item_list[i].item_cost.ToString("N2");
            holderScript.item_description.text = item_list[i].item_description;
            holderScript.item_reqr.text = item_list[i].item_requirements;


        }
    }

}
