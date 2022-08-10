using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Transform player;
    public TMPro.TextMeshProUGUI scoreText;
    float niger;

    // Update is called once per frame
    void Update()
    {
        niger = player.position.z+3;
        scoreText.text = niger.ToString("0");
    }

}

