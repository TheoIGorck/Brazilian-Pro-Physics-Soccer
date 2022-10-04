using UnityEngine;

public class BoostTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 12)
        {
            if(TryGetComponent<IBoost>(out IBoost boost))
            {
                boost.HasCollided = true;
            }
        }
    }
}
