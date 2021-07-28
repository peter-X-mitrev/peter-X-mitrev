
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    public float playerscore;

    // Update is called once per frame
    void Update()
    {
        playerscore = -player.position.x;
        scoretext.text = playerscore.ToString("0");
        
    }
}
