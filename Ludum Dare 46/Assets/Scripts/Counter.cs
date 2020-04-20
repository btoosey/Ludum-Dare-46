using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text flyCounter;

    void Update()
    {
        flyCounter.text = GameObject.FindGameObjectsWithTag("Fly").Length.ToString();
    }
}
