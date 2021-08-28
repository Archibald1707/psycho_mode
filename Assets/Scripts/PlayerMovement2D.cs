using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
	public float moveSpeed = 5f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Jump();
		
		//code for horizontal movement
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
		transform.position += movement * Time.deltaTime * moveSpeed;
		
		//code for flipping player when he turn aside
		Vector3 charecterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
            charecterScale.x = -1; 
        if (Input.GetAxis("Horizontal") > 0)
            charecterScale.x = 1;
        transform.localScale = charecterScale;
    }
	
	void Jump()
	{
		if (Input.GetButtonDown("Jump"))
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
	}
}
