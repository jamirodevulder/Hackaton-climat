using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouwOnClick : MonoBehaviour {
    private string BouwplaatsNaam;
    public GameObject toren1;
    public GameObject toren2;
    public GameObject toren3;
    public GameObject toren4;
    public GameObject kogel;
    public string torenbouw;
 
 
	// Use this for initialization
	void Start () {
		
	}
	public void CheckToren(int torennummer)
    {
        if (torennummer == 1)
        {
            torenbouw = "toren1";
        }
        if (torennummer == 2)
        {
            torenbouw = "toren2";
        }
        if (torennummer == 3)
        {
            torenbouw = "toren3";
        }
        if (torennummer == 4)
        {
            torenbouw = "toren4";
        }
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                if (hit.transform != null)
                {
                    print("Hit " + hit.transform.gameObject.name);
                    if(hit.transform.gameObject.name == "BouwPlaat")
                    {
                        
                        
                        

                        BouwplaatsNaam = hit.transform.gameObject.tag;
                        print(GameObject.FindGameObjectWithTag(BouwplaatsNaam).transform.position);
                        Vector3 spawnpositie = new Vector3(GameObject.FindGameObjectWithTag(BouwplaatsNaam).transform.position.x, GameObject.FindGameObjectWithTag(BouwplaatsNaam).transform.position.y, GameObject.FindGameObjectWithTag(BouwplaatsNaam).transform.position.z);
                        if (torenbouw == "toren1")
                        {
                            
                            Instantiate(toren1, spawnpositie, Quaternion.identity);
                            
                            
                        }
                        if (torenbouw == "toren2")
                        {
                            Instantiate(toren2, spawnpositie, Quaternion.identity);
                            
                            
                        }
                        if (torenbouw == "toren3")
                        {
                            Instantiate(toren3, spawnpositie, Quaternion.identity);
                            

                        }
                        if (torenbouw == "toren4")
                        {
                            Instantiate(toren4, spawnpositie, Quaternion.identity);
                            
                          
                        }




                    }
                }
        }
    }
}

