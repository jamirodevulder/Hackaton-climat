using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    private float Hp;
    public Text Health;

    void Start()
    {
        Hp = 200;
        HealthText();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (Hp > 0)
            {
                TakeDamage();
            }
            else
            {
                print("Dead");
            }
        }
    }

    void TakeDamage()
    {
        
        Hp -= 5;
        HealthText();
    }

    void HealthText()
    {
        Health.text = Hp.ToString();
    }


}