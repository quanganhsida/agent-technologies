using System.Collections;
using System.Collections.Generic;
using Unity.Robotics.UrdfImporter.Control;
using UnityEngine;
using UnityEngine.UI;

public class ControllHand : MonoBehaviour
{
    [SerializeField] List<Controller> Control;
    [SerializeField] private Text m_TextNumber;
    // Start is called before the first frame update
    private int Count = 0;
    void Start()
    {
        m_TextNumber.text = (Count + 1).ToString();
        for (int i = 0; i < Control.Count; i++)
        {
            if (i == Count)
            {
                Control[i].CheckControlHand = true;
            }
            else
            {
                Control[i].CheckControlHand = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void InCreaseNumber()
    {
        if (Count == 3)
        {
            Count = 0;
            for (int i = 0; i < Control.Count; i++)
            {
                if (i == Count)
                {
                    Control[i].CheckControlHand = true;
                }
                else
                {
                    Control[i].CheckControlHand = false;
                }
            }
            m_TextNumber.text = (Count + 1).ToString();
            return;
        }
        Count++;
        m_TextNumber.text = (Count + 1).ToString();
        for (int i = 0; i < Control.Count; i++)
        {
            if (i == Count)
            {
                Control[i].CheckControlHand = true;
            }
            else
            {
                Control[i].CheckControlHand = false;
            }
        }
    }

}
