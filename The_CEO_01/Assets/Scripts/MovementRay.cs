using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementRay : MonoBehaviour {
    /*
    public Camera cam;
    public float movingspeed;
    public int multiplier;
    float verti = Input.GetAxis("Vertical");
    public float speed = 1f;
    
    void update()
    {
        if (Input.GetMouseButtonDown(0)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)){
                //transform.Translate(0f, 0f, movingspeed * multiplier);
                transform.position += (hit.point + Vector3.forward * verti) * speed * Time.deltaTime;

            }
        }
    }
     * */

    
    public float speedX = 100;
    public float speedY = 100;
    public Rigidbody2D rb;
    public Vector2 destination;
    public Vector2 place;
    public Vector2 journey;
    public Vector2 gap;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        place = rb.transform.position;
    }
	
    void Update () {
        if (Input.GetMouseButtonDown (0)) {
            destination = Camera.main.ScreenToWorldPoint (Input.mousePosition);
            journey.x = destination.x - place.x;
            //journey.y = destination.y - place.y;
            rb.velocity = new Vector2 (journey.normalized.x * speedX * Time.deltaTime, 0);
        }
     }
    void LateUpdate (){
        place = rb.transform.position;
        gap.x = Mathf.Abs (destination.x) - Mathf.Abs (place.x);
        //gap.y = Mathf.Abs (destination.y) - Mathf.Abs (place.y);
        if (.05 > Mathf.Abs (gap.x)  || transform.position.x == destination.x)
        //if (.05 > Mathf.Abs (gap.y))
        rb.velocity = new Vector2 (0,0);
    }
    
}
