using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject objectToDeactivate;
   

    // Start is called before the first frame update
    void Start()
    {
        GameObject OnTriggerActivate;
    }

    // Update is called once per frame
    void Update()
    {
        OnTriggerActivate: objectToDeactivate.SetActive(false);
    }
}
