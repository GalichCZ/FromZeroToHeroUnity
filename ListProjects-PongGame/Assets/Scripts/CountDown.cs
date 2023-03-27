using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public AudioClip countdownSound;
    private AudioSource audioSource;
    private float timeLeft = 4f;

    // Start is called before the first frame update
    void Start()
    {
        countdownText = GetComponentInChildren<TextMeshProUGUI>();
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(countdownSound);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timeLeft > 1)
        {
            int count = Mathf.FloorToInt(timeLeft);
            countdownText.text = count.ToString();
            timeLeft -= Time.deltaTime;
        }
        else
        {
            countdownText.gameObject.SetActive(false);
        }
    }
}
