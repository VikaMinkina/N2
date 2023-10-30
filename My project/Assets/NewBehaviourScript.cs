using UnityEngine;
using UnityEngine.UI;

public class Destroys : MonoBehaviour
{
    public AudioSource audio;
    public Text scoreText;
    private int scoreNum = 0;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bottle_green")
        {
            audio.Play();
            Destroy(other.gameObject);
            scoreNum++;
            scoreText.text = "Score: " + scoreNum;
        }
        if (other.gameObject.tag == "coins")
        {
            audio.Play();
            Destroy(other.gameObject);
            scoreNum++;
            scoreText.text = "Score: " + scoreNum;
        }

    }
}