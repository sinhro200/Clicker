using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private int score = 20;
    [SerializeField]
    private ScoreLogic slogic;
    [SerializeField]
    private IntUnityEvent _changeScore;
    [SerializeField]
    private IntUnityEvent _gameoverScore;
    
    private int maxScore = 0;
    private void Start()
    {
        _changeScore.Invoke(score);
    }

    public void destroyOnClick(int countDestroyable)
    {
        //string s = "old score : " + score;
        score = slogic.updateScore(score,ScoreLogic.DestroyType.OnClick, countDestroyable);
        //s += " ;  new score : " + score;
        _changeScore.Invoke(score);
        checkScore();
        //Debug.Log(s);
    }

    public void destroyOnOut(int count = 1)
    {
        score = slogic.updateScore(score, ScoreLogic.DestroyType.OnOut);
        _changeScore.Invoke(score);
        checkScore();
        //Debug.Log("after out : " + score);
    }

    public void missedClick()
    {
        score = slogic.updateScore(score, ScoreLogic.DestroyType.OnMissed);
        _changeScore.Invoke(score);
        checkScore();
    }

    public int currScore()
    {
        return score;
    }

    private void checkScore()
    {
        maxScore = Mathf.Max(maxScore, score);
        if (score <= 0 )
        {
            Debug.Log("Game Over. max score : " + maxScore);
            _gameoverScore.Invoke(maxScore);
        }
    }
}
