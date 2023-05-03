using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolTipController : MonoBehaviour
{
    private RectTransform imageRectTransform;

    public Vector3 positionInWorldSpace = new Vector3(0, 0, 0);
    public Vector3 pos1 = new Vector3(611, 14, 0);
    public Vector3 pos2 = new Vector3(615, -168, 0);
    public Vector3 pos3 = new Vector3(630, -339, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveImage(int i)
    {
        imageRectTransform = GetComponent<RectTransform>();

        if (i == 2)
        {
            imageRectTransform.anchoredPosition = pos2;
        }
        else if (i == 3)
        {
            imageRectTransform.anchoredPosition = pos3;
        }
        else
        {
            imageRectTransform.anchoredPosition = pos1;
        }
    }
}