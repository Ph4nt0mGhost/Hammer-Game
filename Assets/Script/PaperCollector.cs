using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaperCollector : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paper"))
        {
            Debug.Log("Colliderwith" + other.name);
            //add code so when player collects paper X1 appears wverytime ones collected in the text
            Destroy(other.gameObject);
            
            score += 1;
            scoreText.text = $"Score: {score}";

            if (score >= 15)
            {
                Debug.Log("win");
                SceneManager.LoadScene("Win");
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        score -= 1;
        scoreText.text = $"Score: {score}";
        
        if (score < 0)
        {
            Debug.Log("lose");
            SceneManager.LoadScene("Lose");
        }
    }
}