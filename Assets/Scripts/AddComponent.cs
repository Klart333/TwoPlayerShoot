using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddComponent : MonoBehaviour
{
    public static AddComponent instance;
    void Start()
    {
        // To make sure we have AddComponent on the gameobject we use AddComponentToGameObject, this is very helpfull and the game would not run without this isolated script that adds itself if it doesn't exist except that it can't because it doens't exist
        AddComponentToGameObject<AddComponent>(new AddComponent(), this.gameObject);

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void AddComponentToGameObject<T>(T comp, GameObject gameObject)
    {
        Type type = comp.GetType();
        if (!gameObject.GetComponent(type))
        {
            gameObject.AddComponent(type);
        }
    }
}
