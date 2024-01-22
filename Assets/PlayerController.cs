using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger vao: " + other.gameObject.tag);

        if(other.gameObject.tag == "coin")
        {
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Va cham vao: " + other.gameObject.tag);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space key was pressed");

            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1));
        }else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 0));
            Debug.Log("Left key was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 0));
            Debug.Log("Right key was pressed");
        }
    }
}
