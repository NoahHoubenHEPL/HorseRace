using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform trPlayer;
    [SerializeField] private Transform trCamera;
    [SerializeField] private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        trCamera.position = trPlayer.position + offset;
    }
}
