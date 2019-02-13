using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {
    public Button Button;
    // Use this for initialization
    void Start () {
        Button btn = Button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene("Main");
    }
}
