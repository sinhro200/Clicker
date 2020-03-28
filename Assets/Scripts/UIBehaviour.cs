using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour
{
    
    public Text ScoreText;

    public void setScore(int score)
    {
        ScoreText.text = score.ToString();
    }
}
