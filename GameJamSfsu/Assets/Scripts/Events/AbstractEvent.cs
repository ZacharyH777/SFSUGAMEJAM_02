using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AbstractEvent : MonoBehaviour
{
    static public UnityEvent<ScriptableCard> cardEvent;
    static public UnityEvent<ScriptableEncounter> encounterEvent;
    static public bool encounterLock = false;


    void Awake()
    {
        encounterEvent = new UnityEvent<ScriptableEncounter>();
        encounterEvent.AddListener(printstuff);
    }
    ScriptableEncounter fakeEncounter;
    public void RunEncounter() {
        if (!encounterLock) {
            encounterEvent.Invoke(fakeEncounter);
        }
        Debug.Log("hello");
    }

    void printstuff(ScriptableEncounter i) {
        Debug.Log("printstuff");
    }
}
