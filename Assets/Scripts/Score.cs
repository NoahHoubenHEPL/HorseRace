using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform trPlayer;
    [SerializeField] private TextMeshProUGUI txtScore;
    void FixedUpdate()
    {
        txtScore.text = "Score = " + trPlayer.position.z.ToString("0");
    }
}
