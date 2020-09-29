using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.LandscapeLeft:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -105.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -105.0f);

                Debug.Log("LandscapeLeft");
                break;
            case DeviceOrientation.LandscapeRight:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -105.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-490.0f, -105.0f);

                Debug.Log("LandscapeRight");
                break;
            case DeviceOrientation.Portrait:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -185.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349.0f, -185.0f);
                Debug.Log("Portrait");
                break;
            case DeviceOrientation.Unknown:
                Debug.Log("Unknown");
                break;
        }
    }
}
