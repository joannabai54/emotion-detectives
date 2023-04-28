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
    public notebookController notebook;

    public emotionsController vaseEmotions;
    public emotionsController doorEmotions;
    public emotionsController cakeEmotions;
    public emotionsController bannerEmotions;
    public emotionsController giftEmotions;
    public emotionsController tearsEmotions;

    public GameObject[] tooltips;
    public GameObject toolTipBlocker;

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
        notebook.gameObject.SetActive(false);

        vaseEmotions.enableToggles(false);
        doorEmotions.enableToggles(false);
        cakeEmotions.enableToggles(false);
        bannerEmotions.enableToggles(false);
        giftEmotions.enableToggles(false);
        tearsEmotions.enableToggles(false);

        toolTipBlocker.SetActive(true);
        tooltips[0].SetActive(true);
        tooltips[1].SetActive(false);
        tooltips[2].SetActive(false);

        //for (int i = 0; i < tooltips.Length; i++)
        //{
        //    tooltips[i].SetActive(true);
        //}
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
            vaseEmotions.enableToggles(true);
        }

        if (evidenceName == "door")
        {
            door.sprite = normalDoor;
            clipboardDoor.sprite = normalDoor;
            clipboard.currentPage = 1;
            doorEmotions.enableToggles(true);
        }

        if (evidenceName == "cake")
        {
            cake.sprite = normalCake;
            clipboardCake.sprite = normalCake;
            clipboard.currentPage = 2;
            cakeEmotions.enableToggles(true);
        }

        if (evidenceName == "banner")
        {
            banner.sprite = normalBanner;
            clipboardBanner.sprite = normalBanner;
            clipboard.currentPage = 2;
            bannerEmotions.enableToggles(true);
        }

        if (evidenceName == "gift")
        {
            gift.sprite = normalGift;
            clipboardGift.sprite = normalGift;
            clipboard.currentPage = 2;
            giftEmotions.enableToggles(true);
        }

        if (evidenceName == "tears")
        {
            tears.sprite = normalTears;
            clipboardTears.sprite = normalTears;
            clipboard.currentPage = 1;
            tearsEmotions.enableToggles(true);
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

    public void showNotebook()
    {
        notebook.gameObject.SetActive(true);
    }

    public void hideNotebook()
    {
        notebook.gameObject.SetActive(false);
    }
    
}
