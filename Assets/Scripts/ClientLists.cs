﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// call from any script:
//  Debug.Log(ClientLists.GetFromJson("Assets/Data/Objects.json"));

[Serializable]
public class ClientLists
{
    public List<Client> Clients;

    public static ClientLists GetFromJson(string path)
    {
        return CreateFromJSON(System.IO.File.ReadAllText(System.IO.Path.Combine(Application.streamingAssetsPath, path)));
    }

    private static ClientLists CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<ClientLists>(jsonString);
    }

    [Serializable]
    public class Interest
    {
        public string trait;
        public int modifier;
    }
}

// -------------------
[Serializable]
public class Bonus
{
    public string trait;
    public int modifier;
}

[Serializable]
public class Client
{
    public string name;
    public string image; // path to image
    public string sound; // path to soundFile
    public string description;
    public string trait;
    public List<Bonus> bonuses;
    public List<string> allowed_interests;
}
