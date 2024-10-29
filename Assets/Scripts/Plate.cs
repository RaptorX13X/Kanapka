using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    [SerializeField] private Transform anchor;
    [SerializeField] private Transform startingAnchor;
    [SerializeField] private BoxCollider trigger;
    [SerializeField] private float avrgIngSize;
    [SerializeField] private Health health;
    private List<GameObject> objectsOnPlate = new List<GameObject>();
    [SerializeField] private Spawner spawner;
    [SerializeField] ScoreController scoreController;
    [SerializeField] private Vector3 CopyTheBoxColliderCenterHerePlease;
    
    
    [SerializeField] private AudioClip goodIngridientSound;
    [SerializeField] private AudioClip badIngridientSound;
    [SerializeField] private AudioClip roundFinishedSound;
    [SerializeField] private RoundController roundController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ingredient"))
        {
            if (other.TryGetComponent(out GoodIngridient goodIngridient))
            {
                goodIngridient.AnchorYourself(anchor);
                if (goodIngridient.anchored) return;
                anchor = goodIngridient.ingdirientAnchor;
                trigger.center += new Vector3(0, 0, avrgIngSize/1.5f);
                objectsOnPlate.Add(goodIngridient.gameObject);
                scoreController.AddScore();
                SoundManager.instance.PlaySound(goodIngridientSound);
            }
            else if (other.TryGetComponent(out BadIng badIng))
            {
                Destroy(badIng.gameObject);
                health.Damage();
                SoundManager.instance.PlaySound(badIngridientSound);
            }
            else if (other.TryGetComponent(out FinishBun bun))
            {
                bun.AnchorYourself(anchor);
                objectsOnPlate.Add(bun.gameObject);
                StartCoroutine(FinishRoutine());
                anchor = startingAnchor;
                trigger.center = CopyTheBoxColliderCenterHerePlease;
                SoundManager.instance.PlaySound(roundFinishedSound);
            }
        }
    }

    IEnumerator FinishRoutine()
    {
        spawner.StopBun();
        yield return new WaitForSeconds(1f);
        foreach (GameObject go in objectsOnPlate)
        {
            Destroy(go);
        }
        yield return new WaitForSeconds(1f);
        roundController.AddRoundTime();
        spawner.StartSpawning();
    }
}
