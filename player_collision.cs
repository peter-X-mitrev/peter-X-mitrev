using UnityEngine;
public class plater_collision : MonoBehaviour
{
    public player_movement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        AudioSource bonk;
        bonk = GetComponent<AudioSource>();
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            bonk.Play(0);
            FindObjectOfType<gamemanager>().endgame();

        }
    }
}