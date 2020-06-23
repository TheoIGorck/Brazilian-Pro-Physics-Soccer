using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{
    [SerializeField] private PlayerBase[] _players = default;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            foreach(PlayerBase players in _players)
            {
                if (players.GetHasKicked())
                {
                    if (players.GetIsFacingRight())
                    {
                        GetComponentInParent<Rigidbody2D>().AddForce(_players[1].GetKickForce());
                    }
                    else
                    {
                        GetComponentInParent<Rigidbody2D>().AddForce(_players[0].GetKickForce());
                    }
                }
            }
        }
    }
}
