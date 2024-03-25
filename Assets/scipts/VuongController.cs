using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VuongController : MonoBehaviour
{
    public float timeRemaining = 60;
    public Text countdownText;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
    }
    IEnumerator Countdown()
    {
        while (timeRemaining > 0 && !gameOver)
        {
            yield return new WaitForSeconds(1);
            timeRemaining--;
            countdownText.text = "Time: " + timeRemaining.ToString();
        }
        if (!gameOver)
        {
            countdownText.text = "Time's up!";
            GameOver();
        }  
    }
 void GameOver()
    {
        gameOver = true;
        Debug.Log("a");
    }
    
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;
        transform.Translate(movement * 5f * Time.deltaTime);

    }
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Tron"))
        {
            Debug.Log("x"); ;
            Vector2 firstPosition = new Vector2(-9, -2);
            transform.position = firstPosition;
        }
        if (collision.gameObject.name.Equals("Box"))
        {
            Debug.Log("win");
            LoadNextScene();

        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if  (collision.CompareTag("MapEdge"))
        {
            Debug.Log("a");
            Vector2 firstPosition = new Vector2(-9, -2);
            transform.position = firstPosition;
        }
    }
}
