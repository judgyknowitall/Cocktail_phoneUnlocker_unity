using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool locked = true;
    List<int> currentCombo = new List<int>();
    private List<int> pswd = new List<int>() { 6, 5, 1 };


    public void CheckPassword (int id)
    {
        if (locked)
        {
            currentCombo.Add(id);

            if (currentCombo.Count == pswd.Count)
            {
                for (int i = 0; i < currentCombo.Count; i++)
                {
                    if (currentCombo[i] != pswd[i]) return;
                }

                // Password was correct!
                locked = false;
                UnlockPhone();
            }
        }
    }

    void UnlockPhone()
    {
        Debug.Log("PHONE UNLOCKED!");

    }
}
