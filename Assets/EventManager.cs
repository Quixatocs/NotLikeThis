using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {


    public static EventManager instance = null;

    public delegate void Drop();
    public static event Drop drop;



    void Awake()
    {
        singleton();
    }

    void singleton()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }


    public static void invokeSubscribersTo_Drop()
    {
        drop();
    }

        
}
