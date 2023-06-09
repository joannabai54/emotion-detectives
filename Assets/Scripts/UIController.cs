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

    private int solveTipCount;
    private int clipboardCount;

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
        clipboard.changeCurrentPage(1);
        notebook.gameObject.SetActive(false);

        vaseEmotions.enableToggles(false);
        doorEmotions.enableToggles(false);
        cakeEmotions.enableToggles(false);
        bannerEmotions.enableToggles(false);
        giftEmotions.enableToggles(false);
        tearsEmotions.enableToggles(false);

        toolTipBlocker.SetActive(true);
        tooltips[0].SetActive(true);

        for (int i = 1; i < tooltips.Length; i++)
        {
            tooltips[i].SetActive(false);
        }

        solveTipCount = 0;
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
            clipboard.changeCurrentPage(1);

            vaseEmotions.enableToggles(true);
        }

        if (evidenceName == "door")
        {
            door.sprite = normalDoor;
            clipboardDoor.sprite = normalDoor;
            clipboard.changeCurrentPage(1);

            doorEmotions.enableToggles(true);
        }

        if (evidenceName == "cake")
        {
            cake.sprite = normalCake;
            clipboardCake.sprite = normalCake;
            clipboard.changeCurrentPage(2);

            cakeEmotions.enableToggles(true);
        }

        if (evidenceName == "banner")
        {
            banner.sprite = normalBanner;
            clipboardBanner.sprite = normalBanner;
            clipboard.changeCurrentPage(2);

            bannerEmotions.enableToggles(true);
        }

        if (evidenceName == "gift")
        {
            gift.sprite = normalGift;
            clipboardGift.sprite = normalGift;
            clipboard.changeCurrentPage(2);

            giftEmotions.enableToggles(true);
        }

        if (evidenceName == "tears")
        {
            tears.sprite = normalTears;
            clipboardTears.sprite = normalTears;
            clipboard.changeCurrentPage(1);

            tearsEmotions.enableToggles(true);
        }
    }

    public void showClipboard()
    {
        clipboard.gameObject.SetActive(true);
        clipboard.showCurrentPage();

        if (clipboardCount == 0)
        {
            // turn on notebook tool tip
            tooltips[3].SetActive(true);
        }
        clipboardCount = 1;
    }

    public void hideClipboard()
    {
        clipboard.gameObject.SetActive(false);

        if (solveTipCount == 2)
        {
            // set the solve tool tip active the third time they open the notebook
            tooltips[2].SetActive(true);
            toolTipBlocker.SetActive(true);
        }
        solveTipCount += 1;
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
