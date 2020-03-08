using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverBehaviour : MonoBehaviour
{
    [SerializeField]
    private Text end_score_text;
    [SerializeField]
    private GameOverPanel game_over_panel;
    public void setGOScore(int score)
    {
        game_over_panel?.show();
        end_score_text.text = score.ToString();
        
    }
}
