using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyawaMusuh : MonoBehaviour
{
    public float nyawaCurrent = 10;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DamageUpLevel1"))
        {
            nyawaCurrent -= 1;
            MusuhMati();
        }
        else if(other.gameObject.CompareTag("DamageUpLevel2"))
        {
            nyawaCurrent -= 2;
            MusuhMati();
        }
    }

    void MusuhMati()
    {
        if (nyawaCurrent <= 0)
        {
            Destroy(gameObject);
        }
    }
}
