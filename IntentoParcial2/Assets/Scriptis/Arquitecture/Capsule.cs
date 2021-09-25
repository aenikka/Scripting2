using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public  ICapsule m_CurrentState;
    public ColorSO colorSO;



    public void Red()
    {
        m_CurrentState = new RedState();
        m_CurrentState.Execute(colorSO);
    }

    public void Blue()
    {
       m_CurrentState = new BlueState();
       m_CurrentState.Execute(colorSO);
    }
}
