using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour
{
    [SerializeField] 
    private Text _scoreText;
    private void Start()
    {

    }
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
    public void setScore(int score)
    {
        Debug.Log("score set to " + score +" in UIBeh") ;
        _scoreText.text = score.ToString();
    }
}
