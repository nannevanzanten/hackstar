using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeySelect : MonoBehaviour
{
    int index = 0;
    public int totalLevels = 2;
    public float xOffset = 1f;
    public GameObject image;
    public GameObject image2;
    // Start is called before the first frame update
    void Start()
    {
        image.SetActive(true);
        image2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (index < totalLevels - 1)
            {
                image2.SetActive(true);
                image.SetActive(false);
                index++;
                Vector2 position = transform.position;
                position.x += xOffset;
                transform.position = position;
                Debug.Log(index);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {

            if(index > 0)
            {
                image.SetActive(true);
                image2.SetActive(false);
                index--;
                Vector2 position = transform.position;
                position.x -= xOffset;
                transform.position = position;
                Debug.Log(index);
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(index < 1)
            {
                Debug.Log("load");
                SceneManager.LoadScene("SampleScene");
            }
            if(index >0)
            {
                Application.Quit();
            }
        }
    }
}
