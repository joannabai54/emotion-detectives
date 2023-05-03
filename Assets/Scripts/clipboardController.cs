using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clipboardController : MonoBehaviour
{
    public GameObject[] pages;
    public int currentPage;

    // Start is called before the first frame update
    void Start()
    {
        currentPage = 0;
        showCurrentPage();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void nextPage()
    {
        currentPage += 1;
        showCurrentPage();
    }

    public void prevPage()
    {
        currentPage -= 1;
        showCurrentPage();
    }

    public void showCurrentPage()
    {
        for (int i = 0; i < pages.Length; i++)
        {
            if (i == currentPage)
            {
                pages[i].SetActive(true);
            }
            else
            {
                pages[i].SetActive(false);
            }
        }
    }

    public void changeCurrentPage(int i)
    {
        currentPage = i;
        showCurrentPage();
    }
}
