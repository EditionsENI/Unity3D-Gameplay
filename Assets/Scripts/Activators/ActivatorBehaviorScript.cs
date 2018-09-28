using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorBehaviorScript : MonoBehaviour {

    [SerializeField]
    private PlateformMoveScript m_plateformScript;
    public PlateformMoveScript PlateformScript
    {
        get { return m_plateformScript; }
        set { m_plateformScript = value; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            PlateformScript.PlateformActive = false;
        }
    }
}
