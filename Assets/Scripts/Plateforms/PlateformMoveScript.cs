using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformMoveScript : MonoBehaviour {

    [SerializeField]
    private Transform m_target;
    public Transform Target
    {
        get { return m_target; }
        set { m_target = value; }
    }

    [SerializeField]
    private bool m_plateformActive;
    public bool PlateformActive
    {
        get { return m_plateformActive; }
        set { m_plateformActive = value; }
    }

    [SerializeField]
    private float m_linearVelocity;
    public float LinearVelocity
    {
        get { return m_linearVelocity; }
        set { m_linearVelocity = value; }
    }

    private Vector3 startPosition;
    private bool direction;
    private Vector3 _target;

	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        direction = true;
        _target = Target.position;
    }
	
	// Update is called once per frame
	void Update () {
		if(PlateformActive)
        {
            transform.position = Vector3.Lerp(transform.position, _target, LinearVelocity);

            if (direction)
            {
                if(Vector3.Distance(transform.position, _target) < 1.0f)
                {
                    _target = startPosition;
                    direction = !direction;
                }
            }
            else
            {
                if (Vector3.Distance(transform.position, _target) < 1.0f)
                {
                    _target = Target.position;
                    direction = !direction;
                }
            }
        }
	}
}
