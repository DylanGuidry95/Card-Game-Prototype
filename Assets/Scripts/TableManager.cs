﻿using UnityEngine;
using System.Collections.Generic;

public class TableManager : MonoBehaviour
{
    private static TableManager _instance;

    public static TableManager instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<TableManager>();
            }
            return _instance;
        }
    }

    public Dictionary<string, List<GameObject>> m_table =
        new Dictionary<string, List<GameObject>>();

    public List<GameObject> m_deck = new List<GameObject>();
    public List<GameObject> m_hand = new List<GameObject>();
    public List<GameObject> m_field = new List<GameObject>();
    public List<GameObject> m_grave = new List<GameObject>();

    void ShuffleDeck(List<GameObject> a_deck)
    {
        GameObject temp = new GameObject();

        for (int i = 0; i < 100; ++i)
        {
            temp = a_deck[Random.Range(0, a_deck.Count)];
        }

    }

    void Start()
    {
        m_table.Add("deck", m_deck);
        m_table.Add("hand", m_hand);
        m_table.Add("field", m_field);
        m_table.Add("grave", m_grave);
    }
}
