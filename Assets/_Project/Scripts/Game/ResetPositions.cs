using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositions : MonoBehaviour
{
    [SerializeField] private GameObject[] _resetedObjects = default;
    [SerializeField] private List<Vector3> _initialPositions = default;
    [SerializeField] private ScoreTrigger _scoreTrigger = default;
    [SerializeField] private ScoreTrigger_P2 _scoreTrigger_P2 = default;
    private int _id = 0;

    public void TakeInitialPostions()
    {
        //_initialPositions.Insert(0, _positions[0].transform.position);

        foreach(GameObject resetedObjects in _resetedObjects)
        {
            _initialPositions.Insert(_id, resetedObjects.transform.position);
            _id++;
        }
    }

    public void ResetToInitialPositions()
    {
        if (_scoreTrigger.GetIsPlayer1Score() || _scoreTrigger_P2.GetIsPlayer2Score())
        {
            _id = 0;

            foreach (Vector3 position in _initialPositions)
            {
                _resetedObjects[_id].transform.position = position;
                _id++;
            }
        }
    }
}
