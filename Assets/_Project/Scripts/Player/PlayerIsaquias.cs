using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIsaquias : PlayerBase
{
    [SerializeField] GameObject[] _sceneObjects = default;
    private bool isOnTop;

    public override void SpecialPower(bool Button)
    {
        if (Button)
        {
            Physics2D.gravity = new Vector2(0, 9.8f);
            //RotateObjects();
        }
    }

    public void RotateObjects()
    {
        if (isOnTop)
        {
            foreach (GameObject objects in _sceneObjects)
            {
                objects.transform.eulerAngles = new Vector3(0, 0, 180f);
            }
        }
        else
        {
            foreach (GameObject objects in _sceneObjects)
            {
                objects.transform.eulerAngles = Vector3.zero;
            }
        }

        isOnTop = !isOnTop;
    }
}
