using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public static ScoreController scoreController;

    public TextMeshProUGUI scoreUI, ammoUI;

    private int totalScore;


    private void Awake()
    {
        if (scoreController == null)
        {
            scoreController = this;
        }
        scoreUI.text = "Score: 0";
    }

    public void UpdateScore(int score)
    {
        totalScore += score;

        scoreUI.text = "Score: " + totalScore.ToString();
    }

    public void UpdateAmmo(int currentAmmo,int maxAmmo)
    {
      

       ammoUI.text ="Ammo: " + currentAmmo.ToString() + "/" + maxAmmo.ToString();
    }
}
