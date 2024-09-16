using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    ScoreManager sc;

    private void Start()
    {
        sc = FindAnyObjectByType<ScoreManager>();
    }

    public void IsCaught()
    {
        Debug.Log("Caught");
        sc.score += 1;
        sc.UpdateScoreText();
        Destroy(gameObject, 0.5f);
    }
}
