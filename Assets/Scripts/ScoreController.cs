using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private ScoreLogic slogic;
    [SerializeField]
    private IntUnityEvent _changeScore;
    [SerializeField]
    private int beginScore = 20;

    private void Start()
    {
        _changeScore.Invoke(beginScore);
    }

    public void destroyOnClick(int countDestroyable)
    {
        string s = "old score : " + beginScore;
        beginScore = slogic.updateScore(beginScore,ScoreLogic.DestroyType.OnClick, countDestroyable);
        s += " ;  new score : " + beginScore;
        _changeScore.Invoke(beginScore);
        Debug.Log(s);
    }

    public void destroyOnOut(int count = 1)
    {
        beginScore = slogic.updateScore(beginScore, ScoreLogic.DestroyType.OnOut);
        _changeScore.Invoke(beginScore);
        Debug.Log("after out : " + beginScore);
    }

    public int currScore()
    {
        return beginScore;
    }
}
