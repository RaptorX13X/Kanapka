using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    [SerializeField] private Transform anchor;
    [SerializeField] private BoxCollider trigger;
    [SerializeField] private float avrgIngSize;
    [SerializeField] private Health health;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ingredient"))
        {
            if (other.TryGetComponent(out GoodIngridient goodIngridient))
            {
                goodIngridient.AnchorYourself(anchor);
                anchor = goodIngridient.ingdirientAnchor;
                trigger.center += new Vector3(0, avrgIngSize/1.5f, 0);
            }
            else if (other.TryGetComponent(out BadIng badIng))
            {
                Destroy(badIng.gameObject);
                health.Damage();
            }
        }
    }
}
