using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reportController : MonoBehaviour
{
    public GameObject[] speeches;
    public int currentSpeech;
    public clipboardController clipboard;
    public notebookController notebook;
    public GameObject clipboardIcon;
    public GameObject notebookIcon;
    public GameObject notebookToolTip;
    public sceneSwitcher glowingDoor;

    public GameObject friend;
    public GameObject detective;

    // Start is called before the first frame update
    void Start()
    {
        friend.SetActive(true);
        detective.SetActive(true);

        currentSpeech = 0;
        showCurrentSpeech();

        for (int i = 1; i < speeches.Length; i++)
        {
            speeches[i].SetActive(false);
        }

        clipboard.gameObject.SetActive(false);
        notebook.gameObject.SetActive(false);
        clipboardIcon.SetActive(false);
        glowingDoor.gameObject.SetActive(false);

        notebookIcon.SetActive(false);
        notebookToolTip.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextSpeech()
    {
        currentSpeech += 1;
        showCurrentSpeech();
    }

    public void showCurrentSpeech()
    {
        for (int i = 0; i < speeches.Length; i++)
        {
            if (i == currentSpeech)
            {
                speeches[i].SetActive(true);
            }
            else
            {
                speeches[i].SetActive(false);
            }
        }
        if (currentSpeech == speeches.Length - 1)
        {
            clipboardIcon.SetActive(true);
        }
    }

    public void showClipboard()
    {
        clipboard.gameObject.SetActive(true);
    }

    public void hideClipboard()
    {
        clipboard.gameObject.SetActive(false);
        for (int i = 0; i < speeches.Length; i++)
        {
            speeches[i].SetActive(false);
        }
        //notebookIcon.SetActive(true);
        //notebookToolTip.SetActive(true);
        
        friend.SetActive(false);
        detective.transform.position = new Vector3(-4f, -2.36f, 0f);
        glowingDoor.gameObject.SetActive(true);
    }

    public void showNotebook()
    {
        notebook.gameObject.SetActive(true);
    }

    public void hideNotebook()
    {
        notebook.gameObject.SetActive(false);
        notebookToolTip.SetActive(false);
    }

    public void goInside()
    {
        glowingDoor.SwitchScene("Inside Party Lane");
    }
}
