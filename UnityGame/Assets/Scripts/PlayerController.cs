using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public int count;

    void Start()
    {
        count = 0;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        rigidbody.velocity = new Vector3(0f,rigidbody.velocity.y,0f) + new Vector3(moveHorizontal, 0f, moveVertical) * speed;
        
    } 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count++;
        }
    }
    
}
