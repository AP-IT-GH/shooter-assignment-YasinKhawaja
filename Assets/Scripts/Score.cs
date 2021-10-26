using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text TextScore;

    int _count;

    public void UpdateScore()
    {
        _count++;
        TextScore.text = $"Score: {_count}";
    }
}
