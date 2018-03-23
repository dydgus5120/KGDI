using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result
{
    public int[] Guess;
    public int Strike;
    public int Ball;
    public int Out;
}


public class ResultView : MonoBehaviour {

    int submitCount = 0;

    public Transform Content;

    public GameObject ResultItem;
    public GameObject EndItem;
    public GameObject WarningItem;

    public Color StrikeColor;
    public Color BallColor;
    public Color OutColor;

    public Image[] ResultIcons;

	public void DisplayResult(Result result)
    {
        submitCount++;

        if(result.Strike == 3)
        {
            GameObject obj = Instantiate(EndItem, Content);
            obj.GetComponentInChildren<Text>().text = submitCount + "번째만에 정답을 맞추셨습니다.";
        }
        else
        {
            GameObject obj = Instantiate(ResultItem, Content);
            obj.GetComponent<ResultItem>().Setup(submitCount, result);
        }

        //스코어
        //전광판 결과

        for (int i = 0; i < 3; i++)
        {
            if (i < result.Strike)
            {
                ResultIcons[i].color = StrikeColor;
            }
            else if (i < result.Strike + result.Ball)
            {
                ResultIcons[i].color = BallColor;
            }
            else
            {
                ResultIcons[i].color = OutColor;
            }
        }
    }

    public void DisplayWarning()
    {
        Instantiate(WarningItem, Content);
    }

}
