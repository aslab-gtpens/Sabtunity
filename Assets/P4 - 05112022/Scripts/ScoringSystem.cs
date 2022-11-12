using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }



    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        // score++;
    }
}
