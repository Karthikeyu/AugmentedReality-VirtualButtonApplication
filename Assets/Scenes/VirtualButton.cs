using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Sun;
    public GameObject Moon;
    public GameObject Boat;
    VirtualButtonBehaviour virtualButton;

    // Start is called before the first frame update
    void Start()
    {
        virtualButton = GetComponentInChildren<VirtualButtonBehaviour> ();
        virtualButton.RegisterEventHandler(this);
        Sun.SetActive(true);
        Moon.SetActive(false);
        Boat.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Moon.SetActive(true);
        Sun.SetActive(false);
        Boat.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Sun.SetActive(true);
        Moon.SetActive(false);
        Boat.SetActive(false);
    }
}


