using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public static int score { get; set; } = 0;

    public GameObject tryAgainButton;
    public Text scoreText;

    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        scoreText.text = score.ToString();

        if (player == null)
        {
            tryAgainButton.SetActive(true);
        }
    }

    public void UI_TryAgain()
    {
        score = 0;
        SceneManager.LoadScene("Game");
    }
}
