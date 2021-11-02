using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;

    public UnityEvent arrowCoincidedEvent;
    public UnityEvent arrowNotCoincidedEvent;


    public void checkMatch()
    {
        if (arrow1.collidedObject.GetComponent<Cell>().ID == 1)
            arrowCoincidedEvent?.Invoke();
        if (arrow1.collidedObject.GetComponent<Cell>().ID == 2)
            arrowNotCoincidedEvent?.Invoke();
    }
}
