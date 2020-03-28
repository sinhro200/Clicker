using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    
    public ScoreLogic ScoreLogic;
    public IntUnityEvent ChangeScoreEvent;
    public int BeginScore = 20;

    private void Start()
    {
        ChangeScoreEvent.Invoke(BeginScore);
    }

    public void DestroyOnClick(int countDestroyable)
    {
        BeginScore = ScoreLogic.UpdateScore(BeginScore,ScoreLogic.DestroyType.OnClick, countDestroyable);
        ChangeScoreEvent.Invoke(BeginScore);
    }

    public void DestroyOnOut(int count = 1)
    {
        BeginScore = ScoreLogic.UpdateScore(BeginScore, ScoreLogic.DestroyType.OnOut);
        ChangeScoreEvent.Invoke(BeginScore);
    }

    public int CurrScore()
    {
        return BeginScore;
    }
}
