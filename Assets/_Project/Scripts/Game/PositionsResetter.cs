using System.Collections.Generic;
using UnityEngine;

public class PositionsResetter : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] _resetedObjects = default;
    
    private List<Vector3> _initialPositions = new List<Vector3>();
    private int _id = 0;

    public void ResetToInitialPositions()
    {
        _id = 0;

        foreach (Vector3 position in _initialPositions)
        {
            _resetedObjects[_id].transform.position = position;
            _id++;
        }
    }

    private void Start()
    {
        TakeInitialPostions();
    }

    private void TakeInitialPostions()
    {
        foreach(GameObject resetedObjects in _resetedObjects)
        {
            _initialPositions.Insert(_id, resetedObjects.transform.position);
            _id++;
        }
    }
}
