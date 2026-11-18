using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] private GameManagerScript gameManagerScript;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("H o r s e");
        }
    }
}
