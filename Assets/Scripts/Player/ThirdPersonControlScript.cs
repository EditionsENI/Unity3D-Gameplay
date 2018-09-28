using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonControlScript : MonoBehaviour {

    [SerializeField]
    private float m_linearVelocity = 15.0f;
    public float LinearVelocity
    {
        get { return m_linearVelocity; }
        set { m_linearVelocity = value; }
    }

    [SerializeField]
    private float m_angularVelocity = 50.0f;
    public float AngularVelocity
    {
        get { return m_angularVelocity; }
        set { m_angularVelocity = value; }
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.forward * LinearVelocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * LinearVelocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -AngularVelocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, AngularVelocity * Time.deltaTime);
        }
    }
}
