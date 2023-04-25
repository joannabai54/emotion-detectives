using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    public Image door;
    public Image clipboardDoor;
    public Sprite shadowDoor;
    public Sprite normalDoor;

    public Image vase;
    public Image clipboardVase;
    public Sprite shadowVase;
    public Sprite normalVase;

    public Image cake;
    public Image clipboardCake;
    public Sprite shadowCake;
    public Sprite normalCake;

    public Image banner;
    public Image clipboardBanner;
    public Sprite shadowBanner;
    public Sprite normalBanner;

    public Image gift;
    public Image clipboardGift;
    public Sprite shadowGift;
    public Sprite normalGift;

    public Image tears;
    public Image clipboardTears;
    public Sprite shadowTears;
    public Sprite normalTears;

    public clipboardController clipboard;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        vase.sprite = shadowVase;
        clipboardVase.sprite = shadowVase;
        door.sprite = shadowDoor;
        clipboardDoor.sprite = shadowDoor;
        cake.sprite = shadowCake;
        clipboardCake.sprite = shadowCake;
        banner.sprite = shadowBanner;
        clipboardBanner.sprite = shadowBanner;
        gift.sprite = shadowGift;
        clipboardGift.sprite = shadowGift;
        tears.sprite = shadowTears;
        clipboardTears.sprite = shadowTears;
        clipboard.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowEvidence(string evidenceName)
    {
        if (evidenceName == "vase")
        {
            vase.sprite = normalVase;
            clipboardVase.sprite = normalVase;
            clipboard.currentPage = 1;
        }

        if (evidenceName == "door")
        {
            door.sprite = normalDoor;
            clipboardDoor.sprite = normalDoor;
            clipboard.currentPage = 1;
        }

        if (evidenceName == "cake")
        {
            cake.sprite = normalCake;
            clipboardCake.sprite = normalCake;
            clipboard.currentPage = 2;
        }

        if (evidenceName == "banner")
        {
            banner.sprite = normalBanner;
            clipboardBanner.sprite = normalBanner;
            clipboard.currentPage = 2;
        }

        if (evidenceName == "gift")
        {
            gift.sprite = normalGift;
            clipboardGift.sprite = normalGift;
            clipboard.currentPage = 2;
        }

        if (evidenceName == "tears")
        {
            tears.sprite = normalTears;
            clipboardTears.sprite = normalTears;
            clipboard.currentPage = 1;
        }
    }

    public void showClipboard()
    {
        clipboard.gameObject.SetActive(true);
        clipboard.showCurrentPage();
    }

    public void hideClipboard()
    {
        clipboard.gameObject.SetActive(false);
    }
}
