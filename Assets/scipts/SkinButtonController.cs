using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuSkin;
    public Texture btnTexture;
    void Start()
    {
        HideMenu();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (menuSkin.activeSelf)
            {
                HideMenu();
            }
            else
            {
                ShowMenu();
            }
        }
    }
    void ShowMenu()
    {
        menuSkin.SetActive(true);
        Time.timeScale = 0f;
    }
    void HideMenu()
    {
        menuSkin.SetActive(false);
        Time.timeScale = 1f;
    }
}

