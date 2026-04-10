using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.UpArrow))
		{
			//turn up
			transform.Rotate(Vector3.right * Time.deltaTime * 30);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			//turn down
			transform.Rotate(Vector3.left * Time.deltaTime * 30);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			//turn left
			transform.Rotate(Vector3.forward * Time.deltaTime * 30);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			//turn right
			transform.Rotate(Vector3.back * Time.deltaTime * 30);
		}

	}

    private void FixedUpdate()
    {
		
	}
}
