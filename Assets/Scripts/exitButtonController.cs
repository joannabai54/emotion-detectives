using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitButtonController : MonoBehaviour
{
    public GameObject evidenceInfo;
    public toolTipController tip;
    public int location;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        evidenceInfo.SetActive(false);

        tip.gameObject.SetActive(true);
        tip.MoveImage(location);

        UIController.Instance.showClipboard();
    }
}
