using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class evidenceController : MonoBehaviour
{
    public GameObject evidenceInfo;

    public SpriteRenderer evidenceSprite;
    public Sprite glowEvidence;
    public Sprite normalEvidence;

    // Start is called before the first frame update
    void Start()
    {
        evidenceInfo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUpAsButton()
    {
        evidenceInfo.SetActive(true);
        UIController.Instance.ShowEvidence(gameObject.name);
    }

    private void OnMouseOver()
    {
        evidenceSprite.sprite = glowEvidence;
    }

    private void OnMouseExit()
    {
        evidenceSprite.sprite = normalEvidence;
    }
}
