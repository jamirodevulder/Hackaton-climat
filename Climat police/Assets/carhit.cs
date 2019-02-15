using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carhit : MonoBehaviour {
    private int count = 0;
    [SerializeField]private ParticleSystem[] smog = new ParticleSystem[3];
    private bool wait = true;
    // Use this for initialization
    void Start () {
        smog[0].enableEmission = false;
        smog[1].enableEmission = false;
        smog[2].enableEmission = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullit")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "enemies")
        {
            Destroy(collision.gameObject);

            if (count <= 2)
            {
                smog[count].enableEmission = true;
                StartCoroutine("waiting");
                if (wait)
                {
                    if (count <= 2)
                    {
                        count++;

                    }
                    wait = false;
                }
            }
            else
            {
                UnityEditor.EditorApplication.isPlaying = false;
                Application.Quit();
            }
        }
    }
    IEnumerator waiting()
    {
        yield return new WaitForSeconds(1);
        wait = true;
    }
}
