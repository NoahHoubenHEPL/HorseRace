using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovementScript;
    [SerializeField] private RawImage deathImage;
    [SerializeField] private Image deathBack;
    [SerializeField] private TextMeshProUGUI txtRip;
    void Start()
    {
        deathImage.CrossFadeAlpha(0, 0.0f, false);
        deathBack.enabled = false;
        txtRip.CrossFadeAlpha(0, 0.0f, false);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Horse was slain by " + collisionInfo.collider.name);
            playerMovementScript.enabled = false;
            deathBack.enabled = true;
        }
    }
    void Update()
    {
        if (deathBack.enabled == true)
        {
            StartCoroutine(waiter());
        }
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        deathImage.CrossFadeAlpha(1, 2.0f, false);
        txtRip.CrossFadeAlpha(1, 2.0f, false);
    }
}