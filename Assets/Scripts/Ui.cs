using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ui : MonoBehaviour
{
    TextMeshProUGUI textScore;
    void Awake()
    {
        textScore = transform.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        
    }

    public void UpdateTextScore(float score) {
        textScore.text = score.ToString();
    }
}
