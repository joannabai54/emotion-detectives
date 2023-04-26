using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emotionsController : MonoBehaviour
{
    public Toggle[] toggles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableToggles(bool state)
    {
        for (int i = 0; i < toggles.Length; i++)
        {
            toggles[i].enabled = state;
        }
    }
}
