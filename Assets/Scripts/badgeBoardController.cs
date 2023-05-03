using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class badgeBoardController : MonoBehaviour
{
    public GameObject[] boards;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < boards.Length; i++)
        {
            boards[i].SetActive(false);
        }

        ChooseScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseScene()
    {
        int cases = StaticVariables.casesSolved;
        if (cases == 1)
        {
            boards[1].SetActive(true);
        }
        else if (cases == 0)
        {
            boards[0].SetActive(true);
        }
    }
}
