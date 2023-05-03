using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolTipController : MonoBehaviour
{
    public GameObject evidenceTip;

    private Vector3 pos1 = new Vector3(611f, 14f, 0f);
    private Vector3 pos2 = new Vector3(615f, -168f, 0f);
    private Vector3 pos3 = new Vector3(630f, -339f, 0f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void toolTipLocation(int i)
    {
        if (i == 2)
        {
            evidenceTip.transform.position = pos2;
        }
        else if (i == 3)
        {
            evidenceTip.transform.position = pos3;
        }
        else
        {
            evidenceTip.transform.position = pos1;
        }
    }
}