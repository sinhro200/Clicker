using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    
    public ScoreLogic ScoreLogic;
    public IntUnityEvent ChangeScoreEvent;


    private int _score;

    private void Start()
    {
        _score = ScoreLogic.BeginScore;
        ChangeScoreEvent.Invoke(_score);
    }

    public void DestroyOnClick(int countDestroyable)
    {
        _score = ScoreLogic.UpdateScore(_score,ScoreLogic.DestroyType.OnClick, countDestroyable);
        ChangeScoreEvent.Invoke(_score);
    }

    public void DestroyOnOut(int count = 1)
    {
        _score = ScoreLogic.UpdateScore(_score, ScoreLogic.DestroyType.OnOut);
        ChangeScoreEvent.Invoke(_score);
    }

    public int CurrScore()
    {
        return _score;
    }
}
