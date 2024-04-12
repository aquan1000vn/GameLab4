using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemuController : MonoBehaviour
{
    public GameObject menuCanvas;
    public GameObject TrangPhuc;
    // Start is called before the first frame update
    void Start()
    {
        HideMenu();
        HideTrangPhuc();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuCanvas.activeSelf)
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
        menuCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
    void HideMenu()
    {
        menuCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
    void HideTrangPhuc()
    {
        TrangPhuc.SetActive(false);
        Time.timeScale = 1f;
    }
}
