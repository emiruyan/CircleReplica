using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CircleScoreController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int score;

    public void IncreaseScoreValue()
    {
        score++;
        SetScoreText();
    }

    private void SetScoreText()
    {
        scoreText.text = score.ToString();
    }
}
