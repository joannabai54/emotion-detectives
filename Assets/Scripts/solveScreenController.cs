using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class solveScreenController : MonoBehaviour
{
    public Sprite[] emotionOptions;
    public int currentEmotion;
    public Sprite blank;
    public Image[] emotion;

    public clipboardController clipboard;
    public GameObject friend;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < emotion.Length; i++)
        {
            emotion[i].sprite = blank;
        }
        friend.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpArrow(Image emotion)
    {
        currentEmotion += 1;
        showCurrentEmotion(emotion);
    }

    public void DownArrow(Image emotion)
    {
        currentEmotion -= 1;
        showCurrentEmotion(emotion);
    }

    public void showCurrentEmotion(Image emotion)
    {
        int len = emotionOptions.Length - 1;
        if (currentEmotion < 0)
        {
            currentEmotion = len;
        }
        else if (currentEmotion > len)
        {
            currentEmotion = 0;
        }
        emotion.sprite = emotionOptions[currentEmotion];
    }

    private Sprite returnCurrentEmotion(Image emotion)
    {
        return emotion.sprite;
    }

    public void solve()
    {
        // check what sprite each emotion is set to
        Sprite emotionOne = returnCurrentEmotion(emotion[0]);
        Sprite emotionTwo = returnCurrentEmotion(emotion[1]);
        Sprite emotionThree = returnCurrentEmotion(emotion[2]);

        Sprite happy = emotionOptions[0];
        Sprite sad = emotionOptions[1];
        Sprite mad = emotionOptions[2];
        Sprite scared = emotionOptions[3];
        Sprite surprised = emotionOptions[4];

        List<Sprite> solutionSet = new List<Sprite>{ happy, sad, surprised };
        int checker = 0;

        // check for emotions
        if (solutionSet.Contains(emotionOne))
        {
            solutionSet.Remove(emotionOne);
            checker += 1;
        }
        if (solutionSet.Contains(emotionTwo))
        {
            solutionSet.Remove(emotionTwo);
            checker += 1;
        }
        if (solutionSet.Contains(emotionThree))
        {
            solutionSet.Remove(emotionThree);
            checker += 1;
        }


        if (checker == 3)
        {
            clipboard.currentPage = 4;
            clipboard.showCurrentPage();
            StaticVariables.casesSolved = 1;
        }
        else
        {
            friend.SetActive(true);

        }
    }
}
