using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    public Text scorePlayerText;
    public Text scoreEnemyText;
    private int scorePlayerQuantity;
    private int scoreEnemyQuantity;
    public SceneChanger sceneChanger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger disparate");
        if (gameObject.tag == "Left")
        {
            scoreEnemyQuantity++;
            UpdateScoreLabel(scoreEnemyText, scoreEnemyQuantity);
        } else if(gameObject.CompareTag("Right"))
        {
            scorePlayerQuantity++;
            UpdateScoreLabel(scorePlayerText, scorePlayerQuantity);
        }
    }

    void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }

    void CheckScore()
    {
        if (scorePlayerQuantity >= 3)
        {
            SceneChanger.ChageSceneTo("WinScene");
        }
        else if(scoreEnemyQuantity >= 3)
        {
            SceneChanger.ChageSceneTo("WinScene");
        }
    }
}
