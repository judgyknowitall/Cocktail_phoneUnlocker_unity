using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool locked;
    List<int> currentCombo = new List<int>();
    private List<int> pswd = new List<int>() { 6, 5, 1 };


    // Start is called before the first frame update
    void Start()
    {
        currentCombo.Clear();
        locked = true;
    }


    void shakePhone()
    {
        // WORK HERE






        CheckPassword();
    }



    // Add ingredient id to current combination
    public void AddToCombo(int id)
    {
        currentCombo.Add(id);
    }


    // Check Password
    public void CheckPassword ()
    {
        if (locked)
        {
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
        SceneManager.LoadScene("Unlocked_scene");
    }
}
