using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static float time = 0;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        time += 1 * Time.deltaTime;
        scoreText.text = "SCORE:" + Mathf.Round(time);
    }
}
